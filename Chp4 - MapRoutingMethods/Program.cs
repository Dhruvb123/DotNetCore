var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.Map("/", () => "Hello World!"); --for all requests
//app.MapGet("/", () => "Get Method");
//app.MapPost("/", () => "Post Method");
//app.MapPut("/", () => "Put Method");
//app.MapDelete("/", () => "Delete Method");

// or

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
})
app.Run();
