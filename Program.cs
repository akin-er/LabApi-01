var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "NSWTA TEST API APP!");

app.Run();
