 


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var version = "0000A015"; 

app.MapGet("/", () => $"NSWTA TEST API APP! {version}-{Guid.NewGuid()}");

app.Run();
