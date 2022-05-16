namespace Ameko.AssCS;

public static class AssParser
{
    public static AssFile LoadAndParse(string filePath)
    {
        // Setup
        var result = new AssFile(new AssInfo(), new List<AssStyle>(), new List<AssEvent>(), new AssMeta());

        // Open the file and begin parsing
        ParseFunc parseState = ParseUnknownLine;
        using var assFile = File.Open(filePath, FileMode.Open);
        // Read de lines
        var reader = new StreamReader(assFile);
        while (reader.ReadLine() is { } cLine)
        {
            // Skip empty strings
            if (cLine.Equals(string.Empty)) continue;

            // Section Headers
            if (cLine.StartsWith('[') && cLine.EndsWith(']'))
            {
                var low = cLine.ToLower();
                parseState = low switch
                {
                    "[v4+ styles]" => ParseStyleLine,
                    "[events]" => ParseEventLine,
                    "[script info]" => ParseScriptInfoLine,
                    "[aegisub project garbage]" => ParseMetadataLine
                };
            }

            // Parse the line based on the current state
            parseState(cLine, result);
        }

        return result;
    }

    #region Parsing Functions

    private delegate void ParseFunc(string line, AssFile file);

    private static void ParseStyleLine(string line, AssFile file)
    {
        if (!line.StartsWith("Style:")) return;
        file.Styles.Add(AssStyle.Make(line["Style:".Length..]));
    }

    private static void ParseEventLine(string line, AssFile file)
    {
        if (line.StartsWith("Dialogue:") || line.StartsWith("Comment:"))
            file.Events.Add(AssEvent.Make(line));
    }

    private static void ParseScriptInfoLine(string line, AssFile file)
    {
        // Skip comments
        if (line.StartsWith(';')) return;
        var pair = line.Split(':');
        if (pair.Length == 2)
            file.ScriptInfo.Add
            (
                pair[0].Trim(),
                pair[1].Trim()
            );
        // Not a key:value pair
        else return;
    }
    private static void ParseMetadataLine(string line, AssFile file)
    {
        var pair = line.Split(":");
        if (pair.Length >= 2)
            file.ScriptMetadata.Add
            (
                pair[0].Trim(),
                String.Join(":",pair,1,pair.Length-1).Trim()
            );
        // Not a key:value pair
        else return;
    }

    private static void ParseUnknownLine(string line, AssFile file)
    {
        // Skip, maybe log in the future or something
    }

    #endregion Parsing Functions
}
