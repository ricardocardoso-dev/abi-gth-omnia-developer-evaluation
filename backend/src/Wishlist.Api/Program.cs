namespace Wishlist.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseAuthorization();

        app.MapGet("/health", () => Results.Ok(new { status = "ok" }))
            .WithName("Health");

        app.MapGet("/", () => Results.Ok(new
        {
            service = "wishlist-backend",
            status = "scaffolded",
            version = "0.1.0"
        }))
        .WithName("Root");

        app.Run();
    }
}
