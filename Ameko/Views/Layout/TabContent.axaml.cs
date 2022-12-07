using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Ameko.Views.Layout;

public partial class TabContent : UserControl
{
    public TabContent()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}