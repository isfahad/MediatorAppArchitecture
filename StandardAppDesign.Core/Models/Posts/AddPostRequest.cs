using MediatR;

namespace StandardAppDesign.Core.Models
{
    public class AddPostRequest : IRequest<PostResponse>
    {
        private readonly Post postData;

        public AddPostRequest(Post postData)
        {
            this.postData = postData;
        }
    }
}