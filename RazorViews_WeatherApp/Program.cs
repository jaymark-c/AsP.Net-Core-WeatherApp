var builder = WebApplication.CreateBuilder(args);
// Step 1: Add dependency injection to the service for Controller and Views
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Step 2: 
app.UseStaticFiles();
app.MapControllers();

app.Run();
