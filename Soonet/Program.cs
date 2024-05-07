using Microsoft.EntityFrameworkCore;
using Soonet.Data;
using Microsoft.AspNetCore.Identity;
using Soonet.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("CadenaSQL");

builder.Services.AddDbContext<AppDbContext>(opciones => opciones.UseSqlServer(connectionString));
builder.Services.AddDbContext<SoonetIdentityContext>(opciones => opciones.UseSqlServer(connectionString));

//builder.Services
//        .AddDefaultIdentity<SoonetUser>(options => options.SignIn.RequireConfirmedAccount = true)
//        .AddEntityFrameworkStores<SoonetIdentityContext>();

builder.Services.AddIdentity<SoonetUser,IdentityRole>()
            .AddEntityFrameworkStores<SoonetIdentityContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();


// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();

app.Run();
