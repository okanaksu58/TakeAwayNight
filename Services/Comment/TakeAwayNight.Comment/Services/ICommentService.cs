using TakeAwayNight.Comment.Dtos;

namespace TakeAwayNight.Comment.Services
{
    public interface ICommentService
    {
        Task<List<ResultUserCommentDto>> GetAllUserCommentAsync();
        Task CreateUserCommentAsync(CreateUserCommentDto createUserCommentDto);
        Task UpdateUserCommentAsync(UpdateUserCommentDto updateUserCommentDto);
        Task DeleteeUserCommentAsync(int id);
        Task<GetByIdUserCommentDto> GetByIdUserCommentAsync(int id);
        Task<List<GetByProductIdUserCommentDto>> GetByProductIdUserCommentAsync(string id);
    }
}
