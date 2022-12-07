using Ameko.AssCS;

namespace Ameko.Models;

public class Document
{
    public Document(AssFile file)
    {
        this.File = file;
    }

    public string Title
    {
        get;
        set;
    } = "Untitled";

    public int CurrentLine
    {
        get;
        set;
    } = 0;
    
    public AssFile File { get; private set; }

}