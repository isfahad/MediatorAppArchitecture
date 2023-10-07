using StandardAppDesign.Core.Interfaces.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StandardAppDesign.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowDialogAsync(string message)
        {
            await Application.Current.MainPage.DisplayAlert("", message, "OK");
        }
    }
}