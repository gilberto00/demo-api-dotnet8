using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Bienvenue sur l'API Demo!");

// Endpoint simple
app.MapGet("/api/hello", () =>
{
    return Results.Ok(new
    {
        message = "Bonjour depuis votre API .NET 8 🚀",
        date = DateTime.Now
    });
});

// Endpoint avec paramètre
app.MapGet("/api/math/square/{number:int}", ([FromRoute] int number) =>
{
    if (number < 0)
    {
        return Results.BadRequest(new
        {
            error = "Le nombre ne peut pas être négatif."
        });
    }

    var result = number * number;

    return Results.Ok(new
    {
        number,
        result,
        message = $"Le carré de {number} est {result}"
    });
});

app.Run();
