namespace Blog.Web.Areas.Member.Models.VMs
{
    public class GetArticleVM
    {
        // ARTICLE

        public int ArticleID { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }


        // CATEGORY

        public string CategoryName { get; set; }


        // APPUSER

        public int AppUserID { get; set; }
        public string FullName { get; set; }
    }
}
