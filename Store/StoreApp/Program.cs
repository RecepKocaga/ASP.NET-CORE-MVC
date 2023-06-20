using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);



//web uygulamasına Services (builder)inşaet ya da ekle
//builder inşa et
//Build derleme
builder.Services.AddControllersWithViews();

//DbContext ti Servicese bağladık
builder.Services.AddDbContext<RepositoryContext>(options =>
{
options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
