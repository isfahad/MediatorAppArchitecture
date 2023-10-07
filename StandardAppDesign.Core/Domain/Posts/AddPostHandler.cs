
using MediatR;
using StandardAppDesign.Core.Interfaces.Services;
using StandardAppDesign.Core.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StandardAppDesign.Core.Domain.Posts
{
    public class AddPostHandler : IRequestHandler<AddPostRequest, PostResponse>
    {
        private IHttpApiService apiService;

        public AddPostHandler(IHttpApiService service)
        {
            this.apiService = service;
        }

        public async Task<PostResponse> Handle(AddPostRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await apiService.AddPostAsync(request);
                return response;
            }
            catch (Exception e)
            {
                return PostResponse.WithStatusAndMessage(false, e.Message);
            }
        }
    }
}