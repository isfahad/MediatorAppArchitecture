using StandardAppDesign.Interactor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StandardAppDesign.Views.Posts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostsPage : ContentPage
    {
        public PostsPage(PostViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}