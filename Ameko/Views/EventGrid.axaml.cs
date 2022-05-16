using System.Collections.ObjectModel;
using Ameko.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ameko.Views;

public partial class EventGrid : UserControl
{
    public EventGrid()
    {
        InitializeComponent();
        var grid = this.Get<DataGrid>("SubGrid");
        grid.Items = new EventGridItems();
        grid.SelectedIndex = 0;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}