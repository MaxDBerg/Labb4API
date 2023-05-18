using AutoMapper;
using Hobbies.Data;
using Hobbies.Dtos;
using Hobbies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hobbies.Controllers
{
    [Route("api/Links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly IRepository<Link> _repository;
        private readonly IMapper _mapper;

        public LinksController(IRepository<Link> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<LinkReadDto>> GetAll()
        {
            var links = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<LinkReadDto>>(links));
        }
        
        [HttpGet("{id}")]
        public ActionResult <LinkReadDto> Get(int id)
        {
            var link = _repository.Get(id);
            if (link != null)
            {
                return Ok(_mapper.Map<LinkReadDto>(link));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult <LinkReadDto> Add(LinkCreateDto linkCreateDto)
        {
            var link = _mapper.Map<Link>(linkCreateDto);
            _repository.Add(link);
            _repository.SaveChanges();

            var linkReadDto = _mapper.Map<LinkReadDto>(link);
            return Ok(linkReadDto);
        }

        [HttpPut]
        public ActionResult <LinkReadDto> Update(int id, LinkCreateDto linkCreateDto)
        {
            var link = _repository.Get(id);
            if (link != null)
            {
                _mapper.Map(linkCreateDto, link);
                _repository.Update(id, link);
                _repository.SaveChanges();

                var linkReadDto = _mapper.Map<LinkReadDto>(link);
                return Ok(linkReadDto);
            }
            return NotFound();
        }

        [HttpDelete]
        public ActionResult <LinkReadDto> Delete(int id)
        {
            var link = _repository.Get(id);
            if (link != null)
            {
                _repository.Remove(id);
                _repository.SaveChanges();

                var linkReadDto = _mapper.Map<LinkReadDto>(link);
                return Ok(linkReadDto);
            }
            return NotFound();
        }
    }
}