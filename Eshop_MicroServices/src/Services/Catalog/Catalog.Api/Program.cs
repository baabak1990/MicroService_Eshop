using Carter;
using Marten;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddMarten(opt =>
{
    opt.Connection(builder.Configuration.GetConnectionString("DatabaseSec")!);
    
}).UseLightweightSessions();

var app = builder.Build();

app.MapCarter();

app.Run();
