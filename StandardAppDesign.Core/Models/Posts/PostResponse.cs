namespace StandardAppDesign.Core.Models
{
    public class PostResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; }

        private PostResponse(bool isSuccess) => IsSuccess = isSuccess;

        private PostResponse(bool success, string message)
        : this(success) => Message = message;

        public static PostResponse WithStatus(bool success)
            => new PostResponse(success);

        public static PostResponse WithStatusAndMessage(bool success, string message)
            => new PostResponse(success, message);
    }
}