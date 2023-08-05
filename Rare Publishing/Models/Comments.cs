namespace Rare_Publishing.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int Author_id { get; set; }
        public int Post_id { get; set; }
        public string content { get; set; }

    }
}
