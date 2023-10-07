using StandardAppDesign.Core.Models;
using System.Threading.Tasks;

namespace StandardAppDesign.Core.Interfaces.Services
{
    public interface IHttpApiService
    {
        Task<PostResponse> AddPostAsync(AddPostRequest request);
    }
}