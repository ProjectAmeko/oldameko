using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ameko.Views.Components;

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