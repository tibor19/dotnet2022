var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello dotNET2022 - now with staging!");

app.Run();
