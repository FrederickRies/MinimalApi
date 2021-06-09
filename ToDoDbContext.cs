namespace Api
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected TodoDbContext()
        {
        }
        public DbSet<WeatherForecast> TodoItems { get; set; }
    }
}
