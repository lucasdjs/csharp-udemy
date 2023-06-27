using IWantApp.Domain.Users;
using IWantApp.Endpoints.Clients;
using IWantApp.Endpoints.Producties;
using Microsoft.AspNetCore.Diagnostics;
using Serilog;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseSerilog((context, configuration) =>
{
    configuration
    .WriteTo.Console()
    .WriteTo.MSSqlServer(
        context.Configuration["Database:IWantDb"],
        sinkOptions: new MSSqlServerSinkOptions()
        {
            AutoCreateSqlTable = true,
            TableName = "LogAPI"
        });

});
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["Database:IWantDb"]);
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
    .RequireAuthenticatedUser()
    .Build();

    options.AddPolicy("EmployeePolicy", p => p
    .RequireAuthenticatedUser()
    .RequireClaim("EmployeeCode"));

    options.AddPolicy("Employee005Policy", p => p
   .RequireAuthenticatedUser()
   .RequireClaim("EmployeeCode", "005"));

});
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateActor = true,
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero,
        ValidIssuer = builder.Configuration["JwtBearerTokenSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtBearerTokenSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["JwtBearerTokenSettings:SecretKey"]))
    };
});

builder.Services.AddScoped<QueryAllUsersWithClaimName>();
builder.Services.AddScoped<UserCreator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapMethods(CategoryPost.Template, CategoryPost.Methods, CategoryPost.Handle);
app.MapMethods(CategoryGetAll.Template, CategoryGetAll.Methods, CategoryGetAll.Handle);
app.MapMethods(CategoryPut.Template, CategoryPut.Methods, CategoryPut.Handle);
app.MapMethods(EmployeePost.Template, EmployeePost.Methods, EmployeePost.Handle);
app.MapMethods(EmployeeGetAll.Template, EmployeeGetAll.Methods, EmployeeGetAll.Handle);
app.MapMethods(TokenPost.Template, TokenPost.Methods, TokenPost.Handle);
app.MapMethods(ProductGetShowcase.Template, ProductGetShowcase.Methods, ProductGetShowcase.Handle);
app.MapMethods(ProductPost.Template, ProductPost.Methods, ProductPost.Handle);
app.MapMethods(ProductGetAll.Template, ProductGetAll.Methods, ProductGetAll.Handle);
app.MapMethods(ClientPost.Template, ClientPost.Methods, ClientPost.Handle);
app.MapMethods(ClientGet.Template, ClientGet.Methods, ClientGet.Handle);

app.UseExceptionHandler("/error");
app.Map("/error", (HttpContext http) =>
{
    var error = http.Features?.Get<IExceptionHandlerFeature>().Error;

    if (error != null)
    {
        if (error is SqlException)
            return Results.Problem(title: "Database out", statusCode: 500);
    }

    return Results.Problem(title: "An error ocorred", statusCode: 500);
});


app.Run();
