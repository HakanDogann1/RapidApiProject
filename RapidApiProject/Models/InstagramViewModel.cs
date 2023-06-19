namespace RapidApiProject.Models
{
    public class InstagramViewModel
    {

      
            public User user { get; set; }


        public class User
        {
            public int follower_count { get; set; }
            public int following_count { get; set; }
            public string username { get; set; }

        }
     
    }
}
