using AutoMapper;
using businessLayer.abstracts;
using DtoLayer.Dtos.authorDto;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public authorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var values = _authorService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertAuthor(authorTable p)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values=_mapper.Map<authorTable>(p);          
            _authorService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteAuthor(int id)
        {
            var authorId = _authorService.getById(id);
            _authorService.delete(authorId);
            return Ok();
        }
        [HttpPut]
        public IActionResult updateAuthor(authorTable p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<authorTable>(p);
            _authorService.update(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult getAuthor(int id)
        {
            var values = _authorService.getById(id);
            return Ok(values);
        }
    }
}
