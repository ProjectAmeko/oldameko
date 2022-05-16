using Ameko.Models;
using ReactiveUI;

namespace Ameko.ViewModels;

public class EventGroupViewModel : ViewModelBase
{
    private EventGridItem? _currentEvent;

    public EventGridItem? CurrentEvent
    {
        get => _currentEvent;
        set => this.RaiseAndSetIfChanged(ref _currentEvent, value);
    }
}