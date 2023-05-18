using AutoMapper;
using Hobbies.Models;

namespace Hobbies.Dtos
{
    public class LinksProfile : Profile
    {
        public LinksProfile()
        {
            // Source -> Target
            CreateMap<Link, LinkReadDto>();
            CreateMap<LinkCreateDto, Link>();
        }
    }
}