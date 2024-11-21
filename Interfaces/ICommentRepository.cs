using System.Collections.Generic;
using System.Threading.Tasks;
using api1.Models;

namespace api1.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?>GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id , Comment commentModel);
        Task<Comment?> DeleteAsync(int id);

    }
}
