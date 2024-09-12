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
           
           return page;
        }
    }
}
