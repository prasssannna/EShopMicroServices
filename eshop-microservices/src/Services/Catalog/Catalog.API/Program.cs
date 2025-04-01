var builder = WebApplication.CreateBuilder(args);

//Add services
var app = builder.Build();
//Add routiong pipeline

app.MapGet("/", () => "Hello World!");

app.Run();
