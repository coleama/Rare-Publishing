namespace Rare_Publishing.Models
{
    public class Subscriptions
    {
        public int Id { get; set; }
        public int Follower_id { get; set; }
        public int Author_id { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}
