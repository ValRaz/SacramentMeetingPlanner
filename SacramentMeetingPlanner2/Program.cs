using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeetingPlanner2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SacramentMeetingPlanner2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SacramentMeetingPlanner2Context") ?? throw new InvalidOperationException("Connection string 'SacramentMeetingPlanner2Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapGet("/", async context =>
{
    context.Response.Redirect("/Meetings");
});


app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
