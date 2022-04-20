namespace Ameko.AssCS;

/// <summary>
/// Style used in the project
/// </summary>
/// <author>9volt</author>
public class AssStyle
{
    public string? Name { get; set; }
    public string? FontName { get; set; }
    public float FontSize { get; set; }
    public AssColor? PrimaryColor { get; set; }
    public AssColor? SecondaryColor { get; set; }
    public AssColor? OutlineColor { get; set; }
    public AssColor? ShadowColor { get; set; }
    public bool Bold { get; set; }
    public bool Italic { get; set; }
    public bool Underline { get; set; }
    public bool StrikeOut { get; set; }
    public float ScaleX { get; set; }
    public float ScaleY { get; set; }
    public float Spacing { get; set; }
    public float Angle { get; set; }
    public int BorderStyle { get; set; }
    public float OutlineWidth { get; set; }
    public float ShadowWidth { get; set; }
    public int Alignment { get; set; }
    public int MarginL { get; set; }
    public int MarginR { get; set; }
    public int MarginV { get; set; }
    public int Encoding { get; set; }

    /// <summary>
    /// Create a new style
    /// </summary>
    /// <param name="data">Style sata string</param>
    /// <returns>A new style</returns>
    public static AssStyle Make(string data)
    {
        data = data.Trim();
        var tokens = data.Split(',');

        return new AssStyle
        {
            Name = tokens[0],
            FontName = tokens[1],
            FontSize = float.Parse(tokens[2]),
            PrimaryColor = AssColor.Make(tokens[3]),
            SecondaryColor = AssColor.Make(tokens[4]),
            OutlineColor = AssColor.Make(tokens[5]),
            ShadowColor = AssColor.Make(tokens[6]),

            Bold = Convert.ToBoolean(int.Parse(tokens[7])),
            Italic = Convert.ToBoolean(int.Parse(tokens[8])),
            Underline = Convert.ToBoolean(int.Parse(tokens[9])),
            StrikeOut = Convert.ToBoolean(int.Parse(tokens[10])),

            ScaleX = float.Parse(tokens[11]),
            ScaleY = float.Parse(tokens[12]),
            Spacing = float.Parse(tokens[13]),
            Angle = float.Parse(tokens[14]),

            BorderStyle = int.Parse(tokens[15]),
            OutlineWidth = float.Parse(tokens[16]),
            ShadowWidth = float.Parse(tokens[17]),
            Alignment = int.Parse(tokens[18]),
            MarginL = int.Parse(tokens[19]),
            MarginR = int.Parse(tokens[20]),
            MarginV = int.Parse(tokens[21]),

            Encoding = int.Parse(tokens[22])
        };
    }

    private static int B(bool input) => input ? 1 : 0;

    public override string ToString() =>
        $"Style: {Name},{FontName},{FontSize},{PrimaryColor},{SecondaryColor},{OutlineColor},{ShadowColor}," +
        $"{B(Bold)},{B(Italic)},{B(Underline)},{B(StrikeOut)},{ScaleX},{ScaleY},{Spacing},{Angle},{BorderStyle}," +
        $"{OutlineWidth},{ShadowWidth},{Alignment},{MarginL},{MarginR},{MarginV},{Encoding}";
}