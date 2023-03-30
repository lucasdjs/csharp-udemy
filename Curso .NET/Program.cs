using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World 4!");

app.MapGet("/teste" ,() => "Stephany Batista" );

app.MapGet("/AddHeader" ,(HttpResponse response) => {
    response.Headers.Add("Teste", "Stephany Batista");
    return new {Name = "Stephanu Batista", Age = 35} ;
     });


// app.MapPost("/saveproduct", (Product product )=> {


// return product.Code + " - " + product.Name;

// });

app.MapGet("/product", (HttpRequest request)=> {

return request.Headers["product-code"].ToString();

});


app.MapGet("/product", ([FromQuery]string dateStart, [FromQuery]string dateEnd)=>{
return dateStart + " - " + dateEnd;

});

// app.MapGet("/getproduct/{code}", ([FromRoute]string code)=>{
// return code;

// });

app.MapPost("/products/", (Product product )=> {

ProductRepository.Add(product);
return Results.Created($"/products/{product.Code}", product.Code);

 

});

app.MapGet("/products/{code}", ([FromRoute]string code)=>{
var product = ProductRepository.GetBy(code);

if(product!=null){
    return Results.Ok(product);
}
return Results.NotFound();


});

app.MapGet("/configuration/database", (IConfiguration config) => {
return Results.Ok($"{config["database:connection"]}/{config["Database:port"]}");

});

app.MapGet("/products/", ()=>{
var product = ProductRepository.BuscarTodos();
if(product!=null){
    return Results.Ok(product);
}

return Results.NotFound();



});



app.MapPut("/products/" , (Product product) =>{
var productSaved = ProductRepository.GetBy(product.Code);
productSaved.Name = product.Name;
if(productSaved.Code!=null) return Results.Ok();

return Results.NotFound();
});

app.MapDelete("/products/{code}", ([FromRoute] string code) =>{

var productSaved = ProductRepository.GetBy(code);
ProductRepository.Remove(productSaved);

var product = ProductRepository.BuscarTodos();

return Results.Ok();

});




app.Run();
public class Product{

    public string Code { get; set; }
    public string Name { get; set; }
}

public static class ProductRepository{

    public static List<Product> Product { get; set; }


    public static void Add(Product product){

        if(Product==null){
            Product=new List<Product>();

        }

        Product.Add(product);
    }

    public static Product GetBy(string code){
      return  Product.FirstOrDefault(x=> x.Code ==code);

    }

    public static Product Edit(string code, Product codes){
        var edit = Product.FirstOrDefault(x=> x.Code ==code);
        edit = codes;

        return edit;
    }

    public static List<Product> BuscarTodos(){
        return Product;
    }

    public static List<Product> Remove(Product product){
        Product.Remove(product);

        return Product;

    }
}



