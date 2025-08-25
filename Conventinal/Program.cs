var builder = WebApplication.CreateBuilder(args);

// Add services for MVC (controllers + views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Enable serving of static files and routing
app.UseStaticFiles();     // For CSS, JS, images, etc.
app.UseRouting();

// Optional: Middleware like authentication or authorization
// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}"); // optional id

app.Run();
