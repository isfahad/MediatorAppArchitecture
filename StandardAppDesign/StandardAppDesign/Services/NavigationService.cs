using StandardAppDesign.Core.Enums;
using StandardAppDesign.Core.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StandardAppDesign.Services
{
    public class NavigationService : INavigationService
    {
        private readonly INavigation Navigation;

        //public NavigationService(INavigation navigation)
        //{
        //    Navigation = navigation;
        //}

        public async Task PushAsync(PageEnum page)
        {
            //await Navigation.PushAsync(cpage);
        }
    }
}