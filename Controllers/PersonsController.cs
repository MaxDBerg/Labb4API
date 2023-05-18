using AutoMapper;
using Hobbies.Data;
using Hobbies.Dtos;
using Hobbies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hobbies.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IRepository<Person> _repository;
        private readonly IMapper _mapper;

        public PersonsController(IRepository<Person> repository, IMapper mapper)
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