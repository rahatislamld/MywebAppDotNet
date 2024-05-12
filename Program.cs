var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => " DotNET Hello World!");

app.Run();
