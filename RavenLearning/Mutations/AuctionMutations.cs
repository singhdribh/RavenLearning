using Raven.Client.Documents;
using Raven.Client.Documents.Linq;
using Raven.Client.Documents.Session;
using RavenLearning.Models;

namespace RavenLearning.Mutations
{
    public class AuctionMutations
    {
        public async Task<IQueryable<Auction>> PlaceBid(IAsyncDocumentSession session, string party, string auctionId, double bidAmount)
        {
            var auctions =await session.Query<Auction>().ToListAsync();
            var actualAuction = auctions.Where(x =>x.Id==auctionId
            && x.invitedParties.Any(x=>x.partyAccountNo==party) 
            && x.startDate<=DateTime.Now 
            && x.endDate>=DateTime.Now
            && !x.bids.Any(x=>x.amount==bidAmount)
            
            ).FirstOrDefault();
            if (actualAuction != null)
            {
                actualAuction.bids.Add(new Bid
                {
                    amount = bidAmount,
                    partyAccountNo = party,
                    time = DateTime.Now,
                });
              await  session.SaveChangesAsync();

            }
            return auctions.AsQueryable();
        }
    }
}
