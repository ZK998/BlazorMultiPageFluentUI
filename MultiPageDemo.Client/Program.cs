using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
using Blazored.LocalStorage;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredLocalStorageAsSingleton();

builder.Services.AddFluentUIComponents();


await builder.Build().RunAsync();
