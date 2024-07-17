using AutoMapper;
using businessLayer.abstracts;
using entityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        public postController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var values = _postService.getAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult insertPost(postTable p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<postTable>(p);
            _postService.insert(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deletePost(int id)
        {
            var postId = _postService.getById(id);
            _postService.delete(postId);
            return Ok();
        }
        [HttpPut]
        public IActionResult updatePost(postTable p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<postTable>(p);
            _postService.update(values);       
            return Ok("Veri başarıyla güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult getPost(int id)
        {
            var values = _postService.getById(id);
            return Ok(values);
        }
    }
}
