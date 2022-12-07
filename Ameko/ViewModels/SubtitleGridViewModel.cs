using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ameko.AssCS;

namespace Ameko.ViewModels;

public class SubtitleGridViewModel : ViewModelBase
{
    public ObservableCollection<AssEvent> Events { get; }

    public SubtitleGridViewModel(IEnumerable<AssEvent> events)
    {
        Events = new ObservableCollection<AssEvent>(events);
    }
}