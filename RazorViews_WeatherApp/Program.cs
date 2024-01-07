using Services;
using Services.IServices;

var builder = WebApplication.CreateBuilder(args);
// Step 1: Add dependency injection to the service for Controller and Views
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IWeatherService, WeatherService>();

var app = builder.Build();

// Step 2: 
app.UseStaticFiles();
app.MapControllers();

app.Run();
