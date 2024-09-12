using Microsoft.Extensions.Http;
using System.Net;
using System.Net.Http;

namespace CdekShoppingParser.Loader
{
    public class HtmlLoader : IHtmlLoader
    {
        private readonly IHttpClientFactory _httpClientFactory;
        
        public HtmlLoader(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string?> GetPageAsync(string link)
        {
            string response = "";
            var request = HttpRequestBuilder.Create(link);

            //      AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli 

          
                using (var httpClient = _httpClientFactory.CreateClient("Named.Client"))
                {
                    var responseMessage = await httpClient.SendAsync(request);
                    response = await responseMessage.Content.ReadAsStringAsync();
                    if (response is null)
                    {
                        return response;
                    }
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        response = await responseMessage.Content.ReadAsStringAsync();
                    }
                } 
            

            return response;
        }
    }
}
