namespace Ameko.AssCS;

/// <summary>
/// A timestamp
/// </summary>
/// <author>9volt</author>
public class AssTime
{
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }
    public int Hundredths { get; set; }

    /// <summary>
    /// Create a timestamp
    /// </summary>
    /// <param name="data">Timestamp in <c>HH:MM:SS.ms</c> format</param>
    /// <returns>New AssTime instance</returns>
    public static AssTime Make(string? data)
    {
        var tokens = data.Split(new char[] { ':', '.' });
        return new AssTime
        {
            Hour = int.Parse(tokens[0]),
            Minute = int.Parse(tokens[1]),
            Second = int.Parse(tokens[2]),
            Hundredths = int.Parse(tokens[3]),
        };
    }

    public override string ToString()
    {
        return $"{Hour}:{Minute:D2}:{Second:D2}.{Hundredths:D3}";
    }
}