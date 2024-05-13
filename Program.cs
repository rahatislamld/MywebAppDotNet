var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/dotnet", () => " DotNET Hello World!");

app.Run();
