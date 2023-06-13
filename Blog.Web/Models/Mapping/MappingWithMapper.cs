using AutoMapper;
using Blog.Model.Entities.Concrete;
using Blog.Web.Areas.Member.Models.DTOs;
using Blog.Web.Areas.Member.Models.VMs;
using Blog.Web.Models.DTOs;
using Blog.Web.Models.VMs;

namespace Blog.Web.Models.Mapping
{
    public class MappingWithMapper:Profile
    {
        public MappingWithMapper()
        {
            CreateMap<CreateUserDTO, AppUser>();

            CreateMap<CreateCategoryDTO, Category>();

            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();

            CreateMap<ArticleCreateVM, Article>();
            CreateMap<ArticleUpdateVM, Article>().ReverseMap();
            CreateMap<ArticleDetaillVM, Article>();
            CreateMap<ArticleDetaillVM, Comment>().ReverseMap();
            CreateMap<AppUserUpdateDTO, AppUser>().ReverseMap();
            CreateMap<ArticleFilterDTO, Article>().ReverseMap();
            CreateMap<AppUserPasswords, AppUserUpdateDTO>().ReverseMap();
        }
    }

    
}
