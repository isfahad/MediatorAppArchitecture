using StandardAppDesign.Core.Interfaces.Services;
using StandardAppDesign.Core.Models;
using System.Threading.Tasks;

namespace StandardAppDesign.Infrastructure.Services
{
    public class HttpApiService : IHttpApiService
    {
        public Task<PostResponse> AddPostAsync(AddPostRequest request)
        {
            return Task.FromResult(PostResponse.WithStatusAndMessage(true, "sucsess"));
        }
    }
}