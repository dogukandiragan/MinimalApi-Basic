using MinimalApiBasics.Endpoints;
using MinimalApiBasics.Services;

var builder = WebApplication.CreateBuilder(args);

 

builder.Services.AddSingleton<IUserService, UserService>();


var app = builder.Build();


app.Urls.Add("http://localhost:5000");

 


app.MapGet("/", () => "Hello World!");

app.MapPost("/Orders", () => "Order Created!");
app.MapCustomerEndpoints();
app.Run();
