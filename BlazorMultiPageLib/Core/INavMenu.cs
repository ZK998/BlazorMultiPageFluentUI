namespace BlazorMultiPageLib.Core;

public interface INavMenu
{
    public Task GoTo(string title, string url);
}