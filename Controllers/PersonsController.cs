using AutoMapper;
using Hobbies.Data;
using Hobbies.Services;
using Hobbies.Dtos;
using Hobbies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hobbies.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsRepo _repository;
        private readonly IMapper _mapper;

        public PersonsController(IPersonsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<PersonReadDto>> GetAll()
        {
            var persons = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<PersonReadDto>>(persons));
        }

        [HttpGet("{id}")]
        public ActionResult <PersonReadDto> Get(int id)
        {
            var person = _repository.Get(id);
            if (person != null)
            {
                return Ok(_mapper.Map<PersonReadDto>(person));
            }
            return NotFound();
        }

        [HttpGet("{id}/interests")]
        public ActionResult <IEnumerable<InterestReadDto>> GetAllInterestsForPerson(int id)
        {
            var interests = _repository.GetAllInterestsForPerson(id);
            return Ok(_mapper.Map<IEnumerable<InterestReadDto>>(interests));
        }

        [HttpGet("{id}/links")]
        public ActionResult <IEnumerable<LinkReadDto>> GetAllLinksForPerson(int id)
        {
            var links = _repository.GetAllLinksForPerson(id);
            return Ok(_mapper.Map<IEnumerable<LinkReadDto>>(links));
        }

        [HttpPost]
        public ActionResult <PersonReadDto> Add(PersonCreateDto personCreateDto)
        {
            var person = _mapper.Map<Person>(personCreateDto);
            _repository.Add(person);
            _repository.SaveChanges();

            var personReadDto = _mapper.Map<PersonReadDto>(person);
            return Ok(personReadDto);
        }

        [HttpPut]
        public ActionResult <PersonReadDto> Update(int id, PersonCreateDto personCreateDto)
        {
            var person = _repository.Get(id);
            if (person != null)
            {
                _mapper.Map(personCreateDto, person);
                _repository.Update(id, person);
                _repository.SaveChanges();

                var personReadDto = _mapper.Map<PersonReadDto>(person);
                return Ok(personReadDto);
            }
            return NotFound();
        }

        [HttpPut("{id}/interests/{interestId}")]
        public ActionResult <PersonReadDto> AddInterestToPerson(int id, int interestId)
        {
            var person = _repository.Get(id);
            if (person != null)
            {
                _repository.AddInterestToPerson(id, interestId);
                _repository.SaveChanges();

                var personReadDto = _mapper.Map<PersonReadDto>(person);
                return Ok(personReadDto);
            }
            return NotFound();
        }

        [HttpDelete]
        public ActionResult <PersonReadDto> Delete(int id)
        {
            var person = _repository.Get(id);
            if (person != null)
            {
                _repository.Remove(id);
                _repository.SaveChanges();

                var personReadDto = _mapper.Map<PersonReadDto>(person);
                return Ok(personReadDto);
            }
            return NotFound();
        }
    }
}