using BookReviewer.Api.Interfaces;
using BookReviewer.Api.Repositories;

namespace BookReviewer.Api.Endpoints;

public static class AuthorEndpoints
{
    public static IServiceCollection AddAuthorEndpoints(this IServiceCollection services)
    {
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        return services;
    }

    public static void UseAuthorEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/authors", async (IAuthorRepository authorRepo) =>
        {
            var authors = await authorRepo.GetAuthorsAsync();
            return Results.Ok(authors);
        });

        app.MapPost("/authors", async (IAuthorRepository authorRepo) =>
        {
            var authors = await authorRepo.GetAuthorsAsync();
            return Results.Ok(authors);
        });
    }
}