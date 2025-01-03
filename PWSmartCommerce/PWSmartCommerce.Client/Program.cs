using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PWSmartCommerce.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://127.0.0.1:5277/") });
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<TenantService>();

await builder.Build().RunAsync();
