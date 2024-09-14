var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Product/{id}", async (context) =>
    {
        var id = Convert.ToInt32(context.Request.RouteValues["ID"]);
        await context.Response.WriteAsync($"This product id is {id}");
    });

    endpoints.MapGet("/Books/{auther}/{id}", async (context) =>
    {
        var bookId = Convert.ToInt32(context.Request.RouteValues["ID"]);
        var autherName = Convert.ToString(context.Request.RouteValues["auther"]);
        await context.Response.WriteAsync($"This auther name is {autherName} and book id is {bookId}");
    });
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync($"This page not found!");
});

app.Run();
