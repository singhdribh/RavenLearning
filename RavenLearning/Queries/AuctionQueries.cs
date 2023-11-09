using HotChocolate.Types;
using Raven.Client.Documents.Linq;
using Raven.Client.Documents.Session;
using RavenLearning.Models;

namespace RavenLearning.Queries
{
    [ExtendObjectType("Query")]
    public class AuctionQueries
    {
        public IRavenQueryable<Auction> GetAuctions(IAsyncDocumentSession session,string party,bool showCompletedAuctions)
        {
            return session.Query<Auction>().Where(x=>x.invitedParties.Any(x=>x.name==party) && x.startDate<DateTime.Now  && (x.endDate>=DateTime.Now||showCompletedAuctions) );
        }
        public IRavenQueryable<Auction> GetAllAuctions(IAsyncDocumentSession session)
        {
            return session.Query<Auction>();
        }
    }
}
