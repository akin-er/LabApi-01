 


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var version = "0000A006"; 

app.MapGet("/", () => $"NSWTA TEST API APP! {version}");

app.Run();
