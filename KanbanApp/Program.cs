using System.Net.Http.Json;
using Blazored.LocalStorage;
using KanbanApp;
using KanbanApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add Blazored LocalStorage for offline storage
builder.Services.AddBlazoredLocalStorage();

// Register your TaskService as singleton
builder.Services.AddScoped<TaskService>();

await builder.Build().RunAsync();
