using MediatR;
using StandardAppDesign.Core.Interfaces.Services;
using StandardAppDesign.Core.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StandardAppDesign.Interactor.ViewModels
{
    public class PostViewModel : BaseViewModel
    {
        private readonly IMediator mediator;
        private readonly IDialogService dialogService;
        private string postDataText;

        public ObservableCollection<Post> Posts { get; set; }

        public string PostDataText
        {
            get => postDataText;
            set => SetProperty(ref postDataText, value);
        }

        public PostViewModel(IMediator mediator, IDialogService dialogService)
        {
            this.mediator = mediator;
            this.dialogService = dialogService;
            Posts = new ObservableCollection<Post>(new List<Post>());
        }

        public ICommand AddPostCommand
        {
            get
            {
                return new Commands.AsyncCommand(async () => await AddPost());
            }
        }

        private async Task AddPost()
        {
            var postData = new Post { PostId = 1, PostText = PostDataText };
            var response = await mediator.Send(new AddPostRequest(postData));
            if (response.IsSuccess)
            {
                Posts.Add(postData);
                await dialogService.ShowDialogAsync("Post Added Successfully");
            }
        }
    }
}