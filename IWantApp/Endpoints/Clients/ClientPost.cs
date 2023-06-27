using IWantApp.Domain.Users;

namespace IWantApp.Endpoints.Clients;

public class ClientPost
{
    public static string Template => "/clients";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    [AllowAnonymous]
    public static async Task<IResult> Action(ClientDTO clientDTO, UserCreator userCreator)
    {
        var userClaims = new List<Claim> {
            new Claim("Cpf", clientDTO.Cpf),
            new Claim("Name", clientDTO.Name),
           };

        (IdentityResult identity, string userId) result = await userCreator.Create(clientDTO.Email, clientDTO.Password, userClaims);

        if (!result.identity.Succeeded)
            return Results.ValidationProblem(result.identity.Errors.ConvertToProblemDetails());

        return Results.Created($"/clients/{result.userId}", result.userId);
    }
}
