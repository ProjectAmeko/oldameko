
namespace Ameko.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            EventGroupVm = new EventGroupViewModel();
        }

        private EventGroupViewModel EventGroupVm { get; set; }
    }
}