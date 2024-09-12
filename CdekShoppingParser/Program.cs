using CdekShoppingParser.Loader;
using System.Net;
using Microsoft.Extensions.Http;
using CdekShoppingParser.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddHttpClient("Named.Client")
    .ConfigurePrimaryHttpMessageHandler(() =>
    {
        return new HttpClientHandler
        {
            AutomaticDecompression =
                            DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli
        };
    });

builder.Services.AddScoped<IHtmlLoader, HtmlLoader>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/{id?}");

app.Run();
