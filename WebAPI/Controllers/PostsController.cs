using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }


        //[SwaggerOparation(Summary = "Retrieves all posts")]
        [SwaggerOperation(Summary = "Retrieves all posts")]
        [HttpGet]
        public IActionResult Get()
        {
            var posts = _postService.GetAllPosts();
            return Ok(posts);
        }

        [SwaggerOperation(Summary = "Retrieves a specific post by unique id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var post = _postService.GetPostById(id);
            if (post == null)
                return NotFound();
            return Ok(post);
        }

        [SwaggerOperation(Summary = "Create a new post")]
        [HttpPost]
        public IActionResult Create(CreatePostDto newPost)
        {
            var post = _postService.AddNewPost(newPost);
            //przesyłamy link do nowego zasobu i nowo utworzony obiekt

            return Created($"api/posts/{post.Id}", post);
        }

        [SwaggerOperation(Summary = "Update a new post")]
        [HttpPut]
        public IActionResult Update(UpdatePostDto updatePost)
        {
            _postService.UpdatePost(updatePost);
            return NoContent();
        }

        [SwaggerOperation(Summary = "Delete a new post")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _postService.DeletePost(id);
            return NoContent();
        }

    }
}
