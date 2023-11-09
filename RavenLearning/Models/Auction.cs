namespace RavenLearning.Models
{
    public class Auction
    {
        public string Id { get; set; }
        public string description { get; set; }
        public List<Party> invitedParties { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Bid> bids { get; set; }
    }
    public class Party
    {
        public string partyAccountNo { get; set; }
        public string name { get; set; }
    }
    public class Bid
    {
        public double amount { get; set; }
        public string partyAccountNo { get; set; }
        public DateTime time { get; set; }
    }
}
