namespace Ameko.AssCS;

/// <summary>
/// Exception used when issues arise involving ASS
/// </summary>
/// <author>9volt</author>
public class AssException : Exception
{
    public AssException(string message) : base($"AssException: {message}")
    {
    }
}