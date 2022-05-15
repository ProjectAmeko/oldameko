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
using DynamicData;
using ReactiveUI;

namespace Ameko.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string? _currentLine;
        private AssEvent? _currentEvent;
        
        public ObservableCollection<AssEvent> Events { get; }

        public MainWindowViewModel()
        {
            Events = new ObservableCollection<AssEvent>(GenerateTestEvents());
        }

        public string? CurrentLine
        {
            get => _currentLine;
            set
            {
                this.RaiseAndSetIfChanged(ref _currentLine, value);
                _currentEvent!.Text = value;
            }
        }

        public AssEvent? CurrentEvent
        {
            get => _currentEvent;
            set
            {
                this.RaiseAndSetIfChanged(ref _currentEvent, value);
                CurrentLine = value?.Text;
            }
        }

        private IEnumerable<AssEvent> GenerateTestEvents()
        {
            var h = AssParser.LoadAndParse("C:\\code\\Ameko\\Ameko\\Assets\\test.ass").Events;
            return h;
        }
    }
}