using Hobbies.Dtos;
using Hobbies.Models;
using AutoMapper;

namespace Hobbies.Profiles
{
    public class InterestsProfile : Profile
    {
        public InterestsProfile()
        {
            // Source -> Target
            CreateMap<Interest, InterestReadDto>();
            CreateMap<InterestCreateDto, Interest>();
        }
    }
}