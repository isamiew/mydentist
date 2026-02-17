using System.Globalization;
using Microsoft.AspNetCore.Localization;
using MyDentist.Web.App;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Localization
builder.Services.AddLocalization();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
else
{
    app.UseHttpsRedirection();
}

// Request localization
var supportedCultures = new[]
{
    new CultureInfo("uz-UZ"),
    new CultureInfo("ru-RU"),
    new CultureInfo("en-US")
};

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("uz-UZ"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});

app.UseStatusCodePagesWithReExecute("/not-found");

app.MapGet("/health", () => "OK");

app.UseAntiforgery();

app.MapControllers();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
