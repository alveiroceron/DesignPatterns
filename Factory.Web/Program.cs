using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient((factory) =>
{
    IConfiguration config = factory.GetRequiredService<IConfiguration>();
    var localpercentage = config.GetValue<decimal>("MyConfig:LocalPercentage");

    return new LocalEarnFactory(localpercentage);
});


builder.Services.AddTransient(_ =>
{
    return new ForeignEarnFactory(
        builder.Configuration.GetSection("MyConfig").GetValue<decimal>("ForeignPercentage"),
        builder.Configuration.GetSection("MyConfig").GetValue<decimal>("Extra"));
});


var app = builder.Build();

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
