
using System.Collections.Generic;
using System.IO;
using System.Reactive;
using Ameko.AssCS;
using Ameko.Views;
using Avalonia.Controls;
using ReactiveUI;

namespace Ameko.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private AssFile? _file;
        public MainWindowViewModel()
        {
            EventGroupVm = new EventGroupViewModel();
        }

        private EventGroupViewModel EventGroupVm { get; }

        public AssFile CurrentFile
        {
            get => _file!;
            set => this.RaiseAndSetIfChanged(ref _file, value);
        }

    }
}