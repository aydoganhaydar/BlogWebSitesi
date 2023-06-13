using Blog.Model.Entities.Abstract;

namespace Blog.Model.Entities.Concrete
{
    public class Like
    {
        // NAVIGATION PROPERTY
        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public int ArticleID { get; set; }

        public Article Article { get; set; }
    }

}