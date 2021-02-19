namespace MediatR
{
    internal interface IRequestHandler
    {
        string GetReleases(string url);
    }
}