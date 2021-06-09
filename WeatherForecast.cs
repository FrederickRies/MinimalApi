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
            app.MapGet("/todoitems/{id}", async ([FromServices] TodoDbContext dbContext, int id) =>
            {
                var todoItem = await dbContext.TodoItems.FindAsync(int.Parse(id.ToString()));
                if (todoItem == null)
                {
                    return new StatusCodeResult(StatusCodes.Status404NotFound);
                }
                return new StatusCodeResult(StatusCodes.Status200OK);
            });
        }
    }
}
