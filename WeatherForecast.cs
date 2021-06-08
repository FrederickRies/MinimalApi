using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Api
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public static void Register(WebApplication app)
        {
            app.MapGet("/todoitems/{id}", async (http) =>
            {
                if (!http.Request.RouteValues.TryGetValue("id", out var id))
                {
                    http.Response.StatusCode = 400;
                    return;
                }

                var dbContext = http.RequestServices.GetService<TodoDbContext>();
                var todoItem = await dbContext.TodoItems.FindAsync(int.Parse(id.ToString()));
                if (todoItem == null)
                {
                    http.Response.StatusCode = 404;
                    return;
                }
            });
        }
    }
}
