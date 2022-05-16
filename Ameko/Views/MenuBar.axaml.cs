using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using Ameko.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;

namespace Ameko.Views;

public partial class MenuBar : UserControl
{
    public MenuBar()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}