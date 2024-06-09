using BackgroundMetiatR;
using BackgroundMetiatR.Application;

using MediatR;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApi();
}
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/create-user", async (ISender sender, CreateUserCommand command) =>
{
    var result = await sender.Send(command);
    return Results.Ok(result);
});

app.Run();
