using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<DialogService>();

await builder.Build().RunAsync();
