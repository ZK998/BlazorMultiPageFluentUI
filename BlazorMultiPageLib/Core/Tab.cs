namespace BlazorMultiPageLib.Core;

public class Tab
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool IsActive { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public string Style
    { get { return IsActive ? "height:100%;width:100%" : "display:none"; } }

    public int TabWidth { get; set; }
}