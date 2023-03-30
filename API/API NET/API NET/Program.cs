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

app.MapPost("/products/", (ProductDTO productDTO, ApplicationDbContext context) => {
    var category = context.Categories.Where(x=>x.Id == productDTO.CategoryId).First();
    var product = new Product {
    Code= productDTO.Code, 
    Name = productDTO.Name,
    Description = productDTO.Description,
    Category = category
    };
    context.Products.Add(product);

    return Results.Created($"/products/{product.Id}", product.Id);

});

app.MapGet("/products/{code}", ([FromRoute] string code) => {
    var product = ProductRepository.GetBy(code);

    if (product != null)
    {
        return Results.Ok(product);
    }
    return Results.NotFound();


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

app.MapPut("/products/", (Product product) => {
    var productSaved = ProductRepository.GetBy(product.Code);
    productSaved.Name = product.Name;


    return Results.Ok();
});

app.MapDelete("/products/{code}", ([FromRoute] string code) => {

    var productSaved = ProductRepository.GetBy(code);
    ProductRepository.Remove(productSaved);

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
