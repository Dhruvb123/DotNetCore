using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use(async(context, next) =>
{
    Console.WriteLine("Middleware1 Before : "+context);
    await next();
    Console.WriteLine("Middleware1 After");
    
});

app.Use(async(context,next) =>
{
    Console.WriteLine("Middleware 2 Before");
    await next();
    Console.WriteLine("Middleware 2 After");

});
app.Run();
