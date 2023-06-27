namespace IWantApp.Endpoints.Categories;

public class CategoryPost
{
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    [Authorize(Policy = "EmployeePolicy")]
    public static async Task<IResult> Action(CategoryDTO categoryDTO, HttpContext http, ApplicationDbContext context)
    {
        var userId = http.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
        var category = new Category(categoryDTO.Name, userId, userId);

        if (!category.IsValid)
        {
            return Results.ValidationProblem(category.Notifications.ConvertToProblemDetails());
        }


        await context.Categories.AddAsync(category);
        await context.SaveChangesAsync();

        return Results.Created($"/categories/{category.Id}", category.Id);
    }
}
