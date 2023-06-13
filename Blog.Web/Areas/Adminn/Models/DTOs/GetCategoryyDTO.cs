using Blog.Model.Entities.Enums;

namespace Blog.Web.Areas.Adminn.Models.DTOs
{
    public class GetCategoryyDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public Onay Onay { get; set; }

        public Statu Statu { get; set; }
    }
}
