using API_NET.Domain;
using API_NET.Infraestuture;
using API_NET.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["Database:SqlServer"]);

var app = builder.Build();
var configuration = app.Configuration;
ProductRepository.Init(configuration);

app.MapGet("/", () => "Hello World!");

app.MapPost("/products/", (ProductDTO productDTO, ApplicationDbContext context) => {
    var category = context.Categories.Where(x => x.Id == productDTO.CategoryId).First();
    var product = new Product
    {
        Code = productDTO.Code,
        Name = productDTO.Name,
        Description = productDTO.Description,
        Category = category
    };

    if (productDTO.Tags != null)
    {
        product.Tags = new List<Tag>();
        foreach (var item in productDTO.Tags)
        {
            product.Tags.Add(new Tag { Name = item});
        }
    }
    context.Products.Add(product);
    context.SaveChanges();

    return Results.Created($"/products/{product.Id}", product.Id);

});

app.MapGet("/products/{id}", ([FromRoute] int id, ApplicationDbContext context) => {
    var product = context.Products
    .Include(x => x.Category)
    .Include(x=>x.Tags)
    .Where(x => x.Id == id).First();

    if (product != null)
    {
        return Results.Ok(product);
    }
    return Results.NotFound();


});


app.MapPut("/products/{id}", ([FromRoute] int id, ProductDTO productDTO, ApplicationDbContext context) => {
    var category = context.Categories.Where(x => x.Id == productDTO.CategoryId).First();

    var product = context.Products
    .Include(x => x.Tags)
    .Where(x => x.Id == id).First();

    product.Code = productDTO.Code;
    product.Name = productDTO.Name;
    product.Description = productDTO.Description;
    product.Category = category;

    if (productDTO.Tags != null)
    {
        product.Tags = new List<Tag>();
        foreach (var item in productDTO.Tags)
        {
            product.Tags.Add(new Tag { Name = item });
        }
    }

    context.SaveChanges();

    return Results.Ok();
});


app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("Teste", "Stephany Batista");
    return new { Name = "Stephanu Batista", Age = 35 };
});


app.MapGet("/product", (HttpRequest request) => {

    return request.Headers["product-code"].ToString();

});


app.MapGet("/product", ([FromQuery] string dateStart, [FromQuery] string dateEnd) => {
    return dateStart + " - " + dateEnd;

});


app.MapGet("/configuration/database", (IConfiguration config) => {
    return Results.Ok($"{config["database:connection"]}/{config["Database:port"]}");

});

app.MapGet("/products/", () => {
    var product = ProductRepository.BuscarTodos();
    if (product != null)
    {
        return Results.Ok(product);
    }

    return Results.NotFound();

});

app.MapDelete("/products/{id}", ([FromRoute] int id, ApplicationDbContext context) => {

    var product = context.Products
    .Where(x => x.Id == id).First();

    context.Products.Remove(product);
    context.SaveChanges();

    return Results.Ok();

});

if (app.Environment.IsStaging())
{
    app.MapGet("/configuration/database", (IConfiguration configuration) =>
    {
        return Results.Ok($"{configuration["database:connection"]}{configuration["databaseport:"]}");
    });
}

app.Run();
