using Raven.Client.Documents;
using RavenLearning.Models;

namespace RavenLearning
{
    public static class Extensions
    {
        public static void SeedData(this WebApplication app)
        {
            #region olderscaffold
            //using var scope =app.Services.CreateScope();
            //using var session = scope.ServiceProvider.GetService<IDocumentStore>().OpenSession();

            //var auctions = new List<Auction>
            //{
            //    new Auction
            //    {
            //        startDate = DateTime.Now,
            //        endDate = DateTime.Now.AddHours(5),
            //        description = "First Auction",
            //        invitedParties = new List<Party>
            //        {
            //            new Party
            //            {
            //                partyAccountNo="A1P1",
            //                name = "FirstParty"
            //            },
            //            new Party
            //            {
            //                partyAccountNo="A1P2",
            //                name = "SecondParty"
            //            },new Party
            //            {
            //                partyAccountNo="A1P3",
            //                name = "ThirdParty"
            //            },new Party
            //            {
            //                partyAccountNo="A1P4",
            //                name = "FourthParty"
            //            }
            //        },
            //        bids = new List<Bid>
            //        {
            //            new Bid
            //            {
            //                amount = 50,
            //                partyAccountNo = "A1P1",
            //                time = DateTime.Now,
            //            },new Bid
            //            {
            //                amount = 51,
            //                partyAccountNo = "A1P2",
            //                time = DateTime.Now,
            //            },new Bid
            //            {
            //                amount = 55,
            //                partyAccountNo = "A1P1",
            //                time = DateTime.Now,
            //            },new Bid
            //            {
            //                amount = 60,
            //                partyAccountNo = "A1P3",
            //                time = DateTime.Now,
            //            }
            //            ,new Bid
            //            {
            //                amount = 61,
            //                partyAccountNo = "A1P4",
            //                time = DateTime.Now,
            //            },

            //        }
            //    },
            //    new Auction
            //    {
            //        startDate = DateTime.Now.AddDays(-1),
            //        endDate = DateTime.Now.AddDays(-1).AddHours(5),
            //        description= "SecondAuction",
            //        invitedParties = new List<Party>
            //        {
            //            new Party
            //            {
            //                partyAccountNo="A1P1",
            //                name = "FirstParty"
            //            },
            //            new Party
            //            {
            //                partyAccountNo="A1P2",
            //                name = "SecondParty"
            //            },new Party
            //            {
            //                partyAccountNo="A1P3",
            //                name = "ThirdParty"
            //            },new Party
            //            {
            //                partyAccountNo="A1P4",
            //                name = "FourthParty"
            //            }
            //        },
            //         bids = new List<Bid>
            //        {
            //            new Bid
            //            {
            //                amount = 50,
            //                partyAccountNo = "A1P1",
            //                time = DateTime.Now,
            //            },new Bid
            //            {
            //                amount = 91,
            //                partyAccountNo = "A1P2",
            //                time = DateTime.Now,
            //            },new Bid
            //            {
            //                amount = 100,
            //                partyAccountNo = "A1P1",
            //                time = DateTime.Now,
            //            },new Bid
            //            {
            //                amount = 120,
            //                partyAccountNo = "A1P3",
            //                time = DateTime.Now,
            //            }
            //            ,new Bid
            //            {
            //                amount = 200,
            //                partyAccountNo = "A1P4",
            //                time = DateTime.Now,
            //            },
            //            new Bid
            //            {
            //                amount = 250,
            //                partyAccountNo = "A1P2",
            //                time = DateTime.Now,
            //            }

            //        }
            //    },
            //    new Auction
            //    {
            //        startDate = DateTime.Now.AddDays(1),
            //        endDate = DateTime.Now.AddDays(1).AddHours(5),
            //        description = "ThirdAuction",
            //       invitedParties = new List<Party>
            //        {
            //            new Party
            //            {
            //                partyAccountNo="A1P1",
            //                name = "FirstParty"
            //            },
            //            new Party
            //            {
            //                partyAccountNo="A1P2",
            //                name = "SecondParty"
            //            },new Party
            //            {
            //                partyAccountNo="A1P3",
            //                name = "ThirdParty"
            //            },new Party
            //            {
            //                partyAccountNo="A1P4",
            //                name = "FourthParty"
            //            }
            //        },
            //       bids = new List<Bid> ()
            //    }
            //};
            //if (!session.Query<Auction>().Any())
            //{
            //    foreach(var auction in auctions)
            //    {
            //        session.Store(auction);
            //    }
            //    session.SaveChanges();
            //}
            #endregion


        }
    }
}
