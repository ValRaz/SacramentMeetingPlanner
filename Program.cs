using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add services to the container BEFORE calling builder.Build()
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SacramentMeetingDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets(); // if using static assets like CSS/JS/images
app.MapRazorPages().WithStaticAssets();

app.Run();
