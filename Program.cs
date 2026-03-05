using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DMScreen.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Wiki servisimizi tüm uygulama boyunca tek bir kopya (Singleton) olarak yaşayacak şekilde ekliyoruz
builder.Services.AddSingleton<DMScreen.Client.Services.WikiService>();
await builder.Build().RunAsync();
