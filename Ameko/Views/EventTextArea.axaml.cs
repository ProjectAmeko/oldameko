using System.Collections.ObjectModel;
using Ameko.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;
using AvaloniaEdit.Document;
using ReactiveUI;

namespace Ameko.Views;

public partial class EventTextArea : UserControl
{
    public EventTextArea()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}