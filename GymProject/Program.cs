using GymProject.BL.Services.AccessServices;
using GymProject.Components;
using GymProject.DAL;
using GymProject.DAL.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


//Variables for MYSql connections
var connectionString = builder.Configuration.GetConnectionString("MysqlConnection");
var mysqlServerVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<ApplicationDbContext>(options=>
{
    options.UseMySql(connectionString, new MySqlServerVersion(mysqlServerVersion),
      o =>
      {
          o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
      });
    options.EnableSensitiveDataLogging(true);
});


builder.Services.AddDbContextFactory<ApplicationDbContext>(options => options.UseMySql(mysqlServerVersion), ServiceLifetime.Scoped);
builder.Services.AddScoped<AccessService>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
