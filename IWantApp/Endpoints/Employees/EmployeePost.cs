using IWantApp.Domain.Users;

namespace IWantApp.Endpoints.Employees;

public class EmployeePost
{
    public static string Template => "/employees";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    [Authorize(Policy = "EmployeePolicy")]
    public static async Task<IResult> Action(EmployeeDTO employeeDTO, HttpContext http, UserCreator userCreator)
    {
        var userId = http.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        var userClaims = new List<Claim> {
            new Claim("Name", employeeDTO.Name),
            new Claim("EmployeeCode", employeeDTO.EmployeeCode),
            new Claim("CreatedBy", userId),
           };

        (IdentityResult identity, string userId) result = await userCreator.Create(employeeDTO.Email, employeeDTO.Password, userClaims);

        if (!result.identity.Succeeded)
            return Results.ValidationProblem(result.identity.Errors.ConvertToProblemDetails());

        return Results.Created($"/employees/{result.userId}", result.userId);
    }
}
