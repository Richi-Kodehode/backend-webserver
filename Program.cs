var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var jsonPayload = new { message = "Hello", content = "Testing Testing" }
    return Result.Ok();
});

app.MapGet("/", () =>
{
    return "Get from '/'";
});

app.MapPost("/", () =>
{
    return "Posting to '/'";
});

app.MapPut("/", () =>
{
    return "Updating '/'";
});

app.MapDelete("/", () =>
{
    return "Deleting '/'";
});

app.Run();
