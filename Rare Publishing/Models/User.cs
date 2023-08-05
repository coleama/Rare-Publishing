using System.ComponentModel.Design;

namespace Rare_Publishing.Modules
{
    public class User
    {
       public int Id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set;}
        public string? email { get; set; }
        public string? password { get; set; }
        public string? username { get; set; }
        public string? bio { get; set; }
        public string? profile_image_url { get; set; }
        public DateTime created_on { get; set; }
        public bool active { get; set; }
    }
}
