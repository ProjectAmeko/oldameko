using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ameko.Views.Components;

public partial class EventGrid : UserControl
{
    public EventGrid()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}