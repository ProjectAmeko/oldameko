namespace Ameko.AssCS;

/// <summary>
/// An ASS-formatted color
/// </summary>
/// <author>9volt</author>
public class AssColor
{
    public int Alpha { get; set; }
    public int Blue { get; set; }
    public int Green { get; set; }
    public int Red { get; set; }

    /// <summary>
    /// Create a new <c>AssColor</c> instance
    /// </summary>
    /// <param name="colorCode">ASS or HTML color code</param>
    /// <returns>A new <c>AssColor</c> instance</returns>
    /// <exception cref="AssException">If the color is invalid</exception>
    public static AssColor Make(string? colorCode)
    {
        if (colorCode == null) throw new AssException("color code is null");
        if (colorCode.StartsWith('&'))
        {
            // Starts at index 2 because &H at beginning
            var index = 2;

            return new AssColor
            {
                // Default to 100% opacity if not given
                Alpha = colorCode.Length == 11 ? HexParse(colorCode, index += 2) : HexParse("FF", 0),
                Blue = HexParse(colorCode, index += 2),
                Green = HexParse(colorCode, index += 2),
                Red = HexParse(colorCode, index += 2),
            };
        }
        else if (colorCode.StartsWith('#'))
        {
            return new AssColor
            {
                // Default to 100% opacity
                Alpha = HexParse("FF", 0),
                Blue = HexParse(colorCode, 1),
                Green = HexParse(colorCode, 3),
                Red = HexParse(colorCode, 5),
            };
        }
        else throw new AssException($"Color {colorCode} is invalid.");
    }

    private static int HexParse(string s, int pos)
    {
        return int.Parse(s.Substring(pos, 2), System.Globalization.NumberStyles.HexNumber);
    }

    public override string ToString()
    {
        var hexAlpha = Alpha.ToString("X2");
        var hexBlue = Blue.ToString("X2");
        var hexGreen = Green.ToString("X2");
        var hexRed = Red.ToString("X2");
        return $"&H{hexAlpha}{hexBlue}{hexGreen}{hexRed}&";
    }
}