 


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var version = "0000A002"; 

app.MapGet("/", () => $"NSWTA TEST API APP! {version}");

app.Run();
