using Hobbies.Models;
using AutoMapper;
using Hobbies.Dtos;

namespace Hobbies.Profiles
{
    public class PersonsProfile : Profile
    {
        public PersonsProfile()
        {
            // Source -> Target
            CreateMap<Person, PersonReadDto>();
            CreateMap<PersonCreateDto, Person>();
        }
    }
}