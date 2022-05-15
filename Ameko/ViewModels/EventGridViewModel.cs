using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Input;
using Ameko.AssCS;
using Ameko.Models;
using DynamicData;
using ReactiveUI;

namespace Ameko.ViewModels;

public class EventGridViewModel : ViewModelBase
{
    private EventGridItem? _currentEvent;

    public EventGridItem? CurrentEvent
    {
        get => _currentEvent;
        set => this.RaiseAndSetIfChanged(ref _currentEvent, value);
    }
}