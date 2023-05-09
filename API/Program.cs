using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Declare the application's entry point.
var app = builder.Build();

// Configure the HTTP request pipeline. (Middleware)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use the routing middleware to map endpoints.
app.UseHttpsRedirection();

// Use the authorization middleware to authenticate users.
app.UseAuthorization();

// Map the controllers to the endpoints.
app.MapControllers();

// Creates the database if it doesn't exist.
using var scope = app.Services.CreateScope();
{
    var services = scope.ServiceProvider;
    try
    {
      var context = services.GetRequiredService<DataContext>();
      await context.Database.MigrateAsync();
      await Seed.SeedData(context);
    }
    catch (Exception ex)
    {
      var logger = services.GetRequiredService<ILogger<Program>>();
      logger.LogError(ex, "An error occurred during migration");
    }
}

// Run the web application.
app.Run();
