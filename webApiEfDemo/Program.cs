using webApiEfDemo.Entitys;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//“¿¿µ◊¢»Î
builder.Services.AddDbContext<EfDemoContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

//public void ConfigureServices(IServiceCollection services)
//{
//    services.AddDbContext<MyDbContext>();
//}
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
