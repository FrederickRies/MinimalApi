using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

const string s1 = $"abc";
const string s2 = $"{s1}edf";

// Add services
builder.Services.AddCors(o =>
	o.AddDefaultPolicy(p =>
		p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();

// Create application
using var app = builder.Build();

// Configure middlewares
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthentication(); 
app.UseAuthorization();

WeatherForecast.Register(app);

// Run the app
await app.RunAsync();