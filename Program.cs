using Microsoft.EntityFrameworkCore;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//JSON return upper case -- for auto complete --new added
builder.Services.AddMvc().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
        }
);

//start ----option 1
//builder.Services.AddDbContext<EmrDbContext>();
//end ----option 1
//start ----option 2
//builder.Services.AddDbContext<EmrDbContext>(options =>
//options.UseSqlite(builder.Configuration.GetConnectionString("DefaulConnection")));
//end ----option 2
builder.Services.AddDbContext<HRDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("HrDbCon")
        ));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


//session --new added
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".sieve.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(3600);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
//session --new added

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Use session - new added
app.UseSession();

app.MapAreaControllerRoute(
            name: "MyAreaAdmin",
            areaName: "Admin",
            pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
