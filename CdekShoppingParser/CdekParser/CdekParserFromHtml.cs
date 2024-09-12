using CdekShoppingParser.Models;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Text;
namespace CdekShoppingParser.CdekParser
{
    public class CdekParserFromHtml
    {
        public List<Product> Parse(IHtmlDocument htmlDocument)
        {
            List<Product> productList = new List<Product>();

            var items = htmlDocument.GetElementsByClassName("ps-product-item");

         

            foreach ( var item in items)
            {
                //недопаршено все просто сгружается в одно свойство 
                productList.Add(new Product() { ProductName = item.Text() }); 
            }

            return productList;

        }
    }
}
