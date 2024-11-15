using Blog304.Components;
using Blog304.Configs;

var builder = WebApplication.CreateBuilder(args);
IWebHostEnvironment environment = builder.Environment;
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddServices(configuration);
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers();
builder.Services.AddMvc();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseConfiguredExceptionHandler(environment);
app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
