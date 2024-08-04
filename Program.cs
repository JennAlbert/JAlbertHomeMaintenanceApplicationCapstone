using JAlbertHomeMaintenanceCapstone.Components;
using Auth0.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using Syncfusion.Blazor;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//Added in PokeAPI to AddHttpClient
builder.Services.AddHttpClient("PokeAPI", client => client.BaseAddress = new Uri(" https://pokeapi.co/api/v2/pokemon/{id or name}/"));
//added in for the button on Assign Chore Buddy
builder.Services.AddSyncfusionBlazor();
//added in to call the PokeAPI for Pokemon Names
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(" https://pokeapi.co/api/v2/pokemon/{id or name}/")
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
    
app.Run();
