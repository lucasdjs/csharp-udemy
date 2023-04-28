﻿using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System.Security.Claims;

namespace IWantApp.Endpoints.Employees;

public class EmployeeGetAll
{
    public static string Template => "/employees";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(int? page, int? rows, IConfiguration configuration)
    {
        if(page == null || rows == null || rows> 10)
        {
            return Results.BadRequest("Deve ser informado a paginação corretamente");
        }

        var db = new SqlConnection(configuration["Database:IWantDb"]);
        var query = @"select Email, ClaimValue as Name
            from AspNetUsers u inner join 
            AspNetUserClaims c on u.id = c.UserId and claimType = 'Name'
            order by Name
            OFFSET (@page - 1 )* @rows ROWS FETCH NEXT @rows ROWS ONLY";

        var employees = db.Query<EmployeeResponse>(query, new {page, rows });


        return Results.Ok(employees);
    }
}
