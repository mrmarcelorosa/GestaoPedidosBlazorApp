using GestaoPedidosBlazorApp.Client;
using GestaoPedidosBlazorApp.Client.Models;
using GestaoPedidosBlazorApp.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();


/*builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.Configuration["http://localhost:5283/"] ?? "http://localhost:5283/")
    });

builder.Services.AddHttpClient<Product, ProductService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["http://localhost:5283/"] ?? "http://localhost:5283/");
});*/



await builder.Build().RunAsync();
