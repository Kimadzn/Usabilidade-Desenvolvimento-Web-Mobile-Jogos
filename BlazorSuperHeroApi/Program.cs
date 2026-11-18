
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasmSuperHeroApi;  

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<BlazorWasmSuperHeroApi.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });

await builder.Build().RunAsync();
