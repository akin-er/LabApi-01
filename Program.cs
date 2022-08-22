 


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var version = "0000A014"; 

app.MapGet("/", () => $"NSWTA TEST API APP! {version}-{Guid.NewGuid()}");

app.Run();
