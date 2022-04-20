namespace Ameko.AssCS;

/// <summary>
/// An event in the subtitle, either <c>Dialogue</c> or <c>Comment</c>.
/// </summary>
/// <author>9volt</author>
public class AssEvent
{
    public bool Comment { get; set; }
    public int Layer { get; set; }
    public AssTime? Start { get; set; }
    public AssTime? End { get; set; }
    public string? Style { get; set; }
    public string? Actor { get; set; }
    public int MarginL { get; set; }
    public int MarginR { get; set; }
    public int MarginV { get; set; }
    public string? Effect { get; set; }
    public string? Text { get; set; }

    /// <summary>
    /// Create a new event from a data string
    /// </summary>
    /// <param name="data">ASS data string</param>
    /// <returns>A new Event</returns>
    /// <exception cref="AssException">If the event type is invalid</exception>
    public static AssEvent Make(string data)
    {
        var comment = false;
        if (data.StartsWith("Dialogue:"))
        {
            comment = false;
            data = data["Dialogue:".Length..];
        }
        else if (data.StartsWith("Comment:"))
        {
            comment = true;
            data = data["Comment:".Length..];
        }
        else throw new AssException("Invalid event type.");
        var tokens = data.TrimStart().Split(',');

        return new AssEvent
        {
            Comment = comment,
            Layer = int.Parse(tokens[0]),
            Start = AssTime.Make(tokens[1]),
            End = AssTime.Make(tokens[2]),
            Style = tokens[3],
            Actor = tokens[4],
            MarginL = int.Parse(tokens[5]),
            MarginR = int.Parse(tokens[6]),
            MarginV = int.Parse(tokens[7]),
            Effect = tokens[8],
            Text = string.Join(',', tokens, 9, tokens.Length - 9)
        };
    }
    
    public override string ToString() =>
        $"{(Comment ? "Comment" : "Dialogue")}: {Layer},{Start},{End},{Style},{Actor},{MarginL},{MarginR},{MarginV},{Effect},{Text}";
}