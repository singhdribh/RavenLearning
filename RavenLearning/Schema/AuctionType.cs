using HotChocolate.Resolvers;
using RavenLearning.Models;

namespace RavenLearning.Schema
{
    public class AuctionType:ObjectType<Auction>
    {
        protected override void Configure(IObjectTypeDescriptor<Auction> descriptor)
        {
            descriptor.Field("highBidder").Resolve((IResolverContext context) =>
            {
                var parentAuction = context.Parent<Auction>();
                var bids = parentAuction.bids.OrderByDescending(x=>x.amount).FirstOrDefault();
                return bids;

            });
            base.Configure(descriptor);
        }
    }
}
