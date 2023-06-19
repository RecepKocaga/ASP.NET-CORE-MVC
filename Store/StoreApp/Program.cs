var builder = WebApplication.CreateBuilder(args);



//web uygulamasına Services (builder)inşaet ya da ekle
//builder inşa et
//Build derleme
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
