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

    private readonly TextEditor _textEditor;
    public EventTextArea()
    {
        InitializeComponent();

        _textEditor = this.FindControl<TextEditor>("Editor");
        _textEditor.Document = new TextDocument();
        
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}