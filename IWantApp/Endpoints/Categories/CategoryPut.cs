namespace IWantApp.Endpoints.Categories;

public class CategoryPut
{
    public static string Template => "/categories/{id:guid}";
    public static string[] Methods => new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    [Authorize(Policy = "EmployeePolicy")]
    public static IResult Action([FromRoute] Guid id, HttpContext http, CategoryDTO categoryDTO, ApplicationDbContext context)
    {
        var userId = http.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        var category = context.Categories.Where(x => x.Id == id).FirstOrDefault();

        if (category == null)
            return Results.NotFound();

        category.EditInfo(categoryDTO.Name, categoryDTO.Active, userId);
        if (!category.IsValid)
            return Results.ValidationProblem(category.Notifications.ConvertToProblemDetails());

        context.SaveChanges();

        return Results.Ok();
    }
}
