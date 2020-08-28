using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            //una forma de pasar de uno a otro
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();

            //otra forma de pasar de uno a otro
            CreateMap<SecurityDto, Security>().ReverseMap();
        }
    }
}
