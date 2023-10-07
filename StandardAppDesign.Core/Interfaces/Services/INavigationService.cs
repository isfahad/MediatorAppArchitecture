using StandardAppDesign.Core.Enums;
using System.Threading.Tasks;

namespace StandardAppDesign.Core.Interfaces
{
    public interface INavigationService
    {
        Task PushAsync(PageEnum page);
    }
}