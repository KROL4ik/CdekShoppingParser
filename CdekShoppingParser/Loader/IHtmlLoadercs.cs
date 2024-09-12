namespace CdekShoppingParser.Loader
{
    public interface IHtmlLoader
    {
        public Task<string?> GetPageAsync(string url);
    }
}
