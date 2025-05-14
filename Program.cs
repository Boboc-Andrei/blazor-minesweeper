using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MinesweeperAPI.Services;
using MinesweeperDotNET;
using MinesweeperDotNET.Game;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5193") });
builder.Services.AddScoped<GameRecordsAPIService>();

// builder.Services.AddScoped(sp => new HttpClient
// {
//     BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
// });

builder.Services.AddTransient<IDifficultyLoader, MockJsonDifficultyLoader>();

builder.Services.AddSingleton<GameManager>();

await builder.Build().RunAsync();
