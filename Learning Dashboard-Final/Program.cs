using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Learning_Dashboard_Final;
using Learning_Dashboard_Final.LearningApp;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<LearningAppService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbChipModule),
        typeof(IgbCheckboxModule),
        typeof(IgbExpansionPanelModule)
    );
}