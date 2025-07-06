

using EduCore.Web;
using EduCore.Web.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    //options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
})
.AddCookie();
//.AddGoogle(GoogleDefaults.AuthenticationScheme, options =>
//{
//    var config = builder.Configuration.GetSection("Authentication:Google");
//    options.ClientId = config["ClientId"];
//    options.ClientSecret = config["ClientSecret"];
//    options.CallbackPath = new PathString("/signin-google");

//});
builder.Services.AddSignalR();



builder.Services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

// Configure session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddRazorPages();



var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Configure default files and static file handling
var options = new DefaultFilesOptions();
options.DefaultFileNames.Clear();
options.DefaultFileNames.Add("Home.html");

app.UseHttpsRedirection();
app.UseDefaultFiles(options);
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.MapHub<ServerHub>("/hub");
app.MapRazorPages();

app.Run();
