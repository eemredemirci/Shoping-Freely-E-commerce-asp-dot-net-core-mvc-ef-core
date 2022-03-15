using Microsoft.AspNetCore.Identity;
using ShoppingFreely.BLL.Dependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddBLLDependencies(builder.Configuration);
builder.Services.AddIdentity<IdentityUser, IdentityRole>();
//builder.Services.AddDbContext<ShoppingFreelyDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ShoppingFreelyDb")));

var app = builder.Build();
IConfiguration configuration = app.Configuration;

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
