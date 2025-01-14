using Microsoft.EntityFrameworkCore;
using TechnicalIssueHandler.BL;
using TechnicalIssueHandler.DAL;
using TechnicalIssueHandler.DAL.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AppAutoMapper();
builder.Services.AddRepositories();
builder.Services.AddService();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Lab"));
});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id:guid?}");

app.Run();