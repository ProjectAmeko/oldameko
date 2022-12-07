using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Ameko.AssCS;
using Ameko.Models;
using DynamicData;

namespace Ameko.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Dictionary<string, Document> DocumentMap = new();
        public TabContentViewModel TabContent { get; }
        
        public MainWindowViewModel()
        {
            TabContent = new TabContentViewModel(DocumentMap);
        }
    }
}