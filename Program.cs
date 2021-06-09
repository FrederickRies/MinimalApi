var builder = WebApplication.CreateBuilder(args);

const string s1 = $"abc";
const string s2 = $"{s1}edf";

// Add services

// Create application
using var app = builder.Build();

// Configure middlewares
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

WeatherForecast.Register(app);

// Run the app
await app.RunAsync();