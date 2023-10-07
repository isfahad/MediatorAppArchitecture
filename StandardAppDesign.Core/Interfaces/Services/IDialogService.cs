using System.Threading.Tasks;

namespace StandardAppDesign.Core.Interfaces.Services
{
    public interface IDialogService
    {
        Task ShowDialogAsync(string message);
    }
}