using JZenoApp.Data;
using JZenoApp.Hubs;
using JZenoApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Emit;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("JZenoContext") ?? throw new InvalidOperationException("Connection string 'JZenoContext' not found.");
builder.Services.AddDbContext<JZenoDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddAuthentication().AddGoogle(googleOptions =>
{
    googleOptions.ClientId = builder.Configuration.GetSection("GoogleAuthSettings")
.GetValue<string>("ClientId")!;
    googleOptions.ClientSecret = builder.Configuration.GetSection("GoogleAuthSettings")
.GetValue<string>("ClientSecret")!;
});
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddDefaultIdentity<User>().AddRoles<IdentityRole>()
                   .AddEntityFrameworkStores<JZenoDbContext>().AddDefaultTokenProviders().AddDefaultUI();
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSignalR();

builder.Services.AddSession(cfg => {                    
    cfg.Cookie.Name = "JZeno";                        
    cfg.IdleTimeout = new TimeSpan(24, 1, 0);           
});
builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
});
var app = builder.Build();
app.UseSession();

// Configure the HTTP request pipeline.
    app.UseMigrationsEndPoint();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapHub<SignalHub>("/chatHub");
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
