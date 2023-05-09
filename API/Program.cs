var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

// Run the web application.
app.Run();
