var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

var app = builder.Build();

// Middleware pipeline
app.UseMiddleware<LoggingMiddleware>();   // middleware của bạn

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();