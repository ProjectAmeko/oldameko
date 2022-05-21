using Ameko.AssCS;
using Ameko.ViewModels;
using ReactiveUI;

namespace Ameko.Models;

/// <summary>
/// This class wraps the AssEvent object allowing for dynamic adjustment of
/// values in the UI
/// </summary>
public class EventGridItem : ViewModelBase
{
    private uint _index;
    private AssEvent _event;

    private bool _comment;
    private int _layer;
    private AssTime? _start;
    private AssTime? _end;
    private string? _startT;
    private string? _endT;
    private string? _style;
    private string? _actor;
    private int _marL;
    private int _marR;
    private int _marV;
    private string? _effect;
    private string? _text;

    public EventGridItem(uint index)
    {
        this._index = index;
        this._event = AssEvent.Default();
        this._comment = _event.Comment;
        this._layer = _event.Layer;
        this._start = _event.Start;
        this._end = _event.End;
        this._startT = this._start!.ToString();
        this._endT = this._end!.ToString();
        this._style = _event.Style;
        this._actor = _event.Actor;
        this._marL = _event.MarginL;
        this._marR = _event.MarginR;
        this._marV = _event.MarginV;
        this._effect = _event.Effect;
        this._text = _event.Text;
    }
    
    public EventGridItem(uint index, AssEvent line) {
        this._index = index;
        this._event = line;
    }
    
    #region Getters/Setters
    
    public uint Index
    {
        get => _index;
        set => this.RaiseAndSetIfChanged(ref _index, value);
    }

    public bool Comment
    {
        get => _comment;
        set
        {
            this.RaiseAndSetIfChanged(ref _comment, value);
            _event.Comment = _comment;
        }
    }

    public int Layer
    {
        get => _layer;
        set
        {
            this.RaiseAndSetIfChanged(ref _layer, value);
            _event.Layer = _layer;
        }
    }

    public AssTime? Start
    {
        get => _start;
        set
        {
            this.RaiseAndSetIfChanged(ref _start, value);
            _event.Start = _start;
            _startT = _start!.ToString();
        }
    }
    
    public string? StartText
    {
        get => _startT;
        set
        {
            this.RaiseAndSetIfChanged(ref _startT, value);
            _event.Start = AssTime.Make(value);
        }
    }

    public AssTime? End
    {
        get => _end;
        set
        {
            this.RaiseAndSetIfChanged(ref _end, value);
            _event.End = _end;
            _endT = _end!.ToString();
        }
    }
    
    public string? EndText
    {
        get => _endT;
        set
        {
            this.RaiseAndSetIfChanged(ref _endT, value);
            _event.End = AssTime.Make(value);
        }
    }

    public string? Style
    {
        get => _style;
        set
        {
            this.RaiseAndSetIfChanged(ref _style, value);
            _event.Style = _style;
        }
    }

    public string? Actor
    {
        get => _actor;
        set
        {
            this.RaiseAndSetIfChanged(ref _actor, value);
            _event.Actor = _actor;
        }
    }

    public int MarginL
    {
        get => _marL;
        set
        {
            this.RaiseAndSetIfChanged(ref _marL, value);
            _event.MarginL = _marL;
        }
    }

    public int MarginR
    {
        get => _marR;
        set
        {
            this.RaiseAndSetIfChanged(ref _marR, value);
            _event.MarginR = _marR;
        }
    }

    public int MarginV
    {
        get => _marV;
        set
        {
            this.RaiseAndSetIfChanged(ref _marV, value);
            _event.MarginV = _marV;
        }
    }

    public string? Effect
    {
        get => _effect;
        set
        {
            this.RaiseAndSetIfChanged(ref _effect, value);
            _event.Effect = _effect;
        }
    }

    public string? Text
    {
        get => _text;
        set
        {
            this.RaiseAndSetIfChanged(ref _text, value);
            _event.Text = _text;
        }
    }

    #endregion Getters/Setters
}