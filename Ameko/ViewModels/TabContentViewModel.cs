using System.Collections.Generic;
using Ameko.AssCS;
using Ameko.Models;

namespace Ameko.ViewModels;

public class TabContentViewModel : ViewModelBase
{
    public SubtitleGridViewModel SubtitleGrid { get; }
    public Dictionary<string, Document> Documents { get; }

    public TabContentViewModel(Dictionary<string, Document> documents)
    {
        Documents = documents;
        var a = AssEvent.Default();
        var b = AssEvent.Default();
        var c = AssEvent.Default();
        var d = AssEvent.Default();
        a.Text = "走れそりよ";
        b.Text = "風のように";
        c.Text = "月見原を";
        d.Text = "パドルパドル！";
        var events = new List<AssEvent>
        {
            a, b, c, d
        };
        SubtitleGrid = new SubtitleGridViewModel(events);
    }
}