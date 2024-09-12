using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using CdekShoppingParser.CdekParser;
using CdekShoppingParser.Loader;
using Microsoft.AspNetCore.Mvc;

namespace CdekShoppingParser.Controllers
{
    public class MainController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHtmlLoader _htmlLoader;
        public MainController(IHttpClientFactory httpClientFactory,IHtmlLoader htmlLoader)
        {
            _httpClientFactory= httpClientFactory;
            _htmlLoader= htmlLoader;
        }
        public async Task<string> Index()
        {
           var page = await  _htmlLoader.GetPageAsync("https://cdek.shopping/c/83/noutbuki");

           HtmlParser htmlParser = new();

           var res = await htmlParser.ParseDocumentAsync(page);
           CdekParserFromHtml cdekParser = new CdekParserFromHtml();
           var list =  cdekParser.Parse(res);

            string s="";
            foreach (var e in list)
            {
                s += e.ProductName;
            }

           return s+"aboba";
        }
    }
}
