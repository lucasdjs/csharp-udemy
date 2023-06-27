namespace IWantApp.Endpoints.Clients;

public class ClientGet
{
    public static string Template => "/clients";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    [AllowAnonymous]
    public static async Task<IResult> Action(HttpContext http)
    {
        var user = http.User;

        var result = new
        {
            Id = user.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value,
            Name = user.Claims.First(x => x.Type == "Name").Value,
            Cpf = user.Claims.First(x => x.Type == "Cpf").Value,

        };

        return Results.Ok(result);

    }
}
