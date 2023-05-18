using AutoMapper;
using Hobbies.Data;
using Hobbies.Dtos;
using Hobbies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hobbies.Controllers
{
    [Route("api/Interests")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        private readonly IRepository<Interest> _repository;
        private readonly IMapper _mapper;

        public InterestsController(IRepository<Interest> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<InterestReadDto>> GetAll()
        {
            var interests = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<InterestReadDto>>(interests));
        }

        [HttpGet("{id}")]
        public ActionResult <InterestReadDto> Get(int id)
        {
            var interest = _repository.Get(id);
            if (interest != null)
            {
                return Ok(_mapper.Map<InterestReadDto>(interest));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult <InterestReadDto> Add(InterestCreateDto interestCreateDto)
        {
            var interest = _mapper.Map<Interest>(interestCreateDto);
            _repository.Add(interest);
            _repository.SaveChanges();

            var interestReadDto = _mapper.Map<InterestReadDto>(interest);
            return Ok(interestReadDto);
        }

        [HttpPut]
        public ActionResult <InterestReadDto> Update(int id, InterestCreateDto interestCreateDto)
        {
            var interest = _repository.Get(id);
            if (interest != null)
            {
                _mapper.Map(interestCreateDto, interest);
                _repository.Update(id, interest);
                _repository.SaveChanges();

                var interestReadDto = _mapper.Map<InterestReadDto>(interest);
                return Ok(interestReadDto);
            }
            return NotFound();
        }

        [HttpDelete]
        public ActionResult <InterestReadDto> Delete(int id)
        {
            var interest = _repository.Get(id);
            if (interest != null)
            {
                _repository.Remove(id);
                _repository.SaveChanges();

                var interestReadDto = _mapper.Map<InterestReadDto>(interest);
                return Ok(interestReadDto);
            }
            return NotFound();
        }
    }
}