using Microsoft.EntityFrameworkCore;
using EntityFrameworkPractice3.Data;
using EntityFrameworkPractice3.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkPractice3.Controllers;

public static class DepartmentEndpoints
{
    public static void MapDepartmentEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Department", async (EntityFrameworkPractice3Context db) =>
        {
            return await db.Department.ToListAsync();
        })
        .WithName("GetAllDepartments");

        routes.MapGet("/api/Department/{id}", async (int DeptId, EntityFrameworkPractice3Context db) =>
        {
            return await db.Department.FindAsync(DeptId)
                is Department model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetDepartmentById");

        routes.MapPut("/api/Department", async ([FromQuery] int DeptId, [FromBody] Department department, EntityFrameworkPractice3Context db) =>
        {
            var foundModel = await db.Department.FindAsync(DeptId);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateDepartment");

        routes.MapPost("/api/Department/", async (Department department, EntityFrameworkPractice3Context db) =>
        {
            db.Department.Add(department);
            await db.SaveChangesAsync();
            return Results.Created($"/Departments/{department.DeptId}", department);
        })
        .WithName("CreateDepartment");

        routes.MapDelete("/api/Department/{id}", async (int DeptId, EntityFrameworkPractice3Context db) =>
        {
            if (await db.Department.FindAsync(DeptId) is Department department)
            {
                db.Department.Remove(department);
                await db.SaveChangesAsync();
                return Results.Ok(department);
            }

            return Results.NotFound();
        })
        .WithName("DeleteDepartment");
    }
}
