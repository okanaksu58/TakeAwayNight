using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Comment.Dtos;
using TakeAwayNight.Comment.Services;

namespace TakeAwayNight.Comment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public UserCommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUserComment()
        {
            var values =await _commentService.GetAllUserCommentAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserComment(CreateUserCommentDto createUserCommentDto)
        {
            await _commentService.CreateUserCommentAsync(createUserCommentDto);
            return Ok("Ekleme İşlemi Başarılı!");
        }
        [HttpDelete]
        public async Task<IActionResult> UserDeleteComment(int id)
        {
            await _commentService.DeleteeUserCommentAsync(id);
            return Ok("Silme İşlemi Başarılı!");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUserComment(UpdateUserCommentDto updateUserCommentDto)
        {
            await _commentService.UpdateUserCommentAsync(updateUserCommentDto);
            return Ok("Yorum Güncellendi");
        }
        [HttpGet("UserCommentByProductId")]
        public async Task<IActionResult> UserCommentByProductId(string id)
        {
            var values=await _commentService.GetByProductIdUserCommentAsync(id);
            return Ok(values);
        }
        [HttpGet("GetUserComment")]
        public async Task<IActionResult> GetUserComment(int id)
        {
            var values=await _commentService.GetByIdUserCommentAsync(id);
            return Ok(values);
        }
    }
}
