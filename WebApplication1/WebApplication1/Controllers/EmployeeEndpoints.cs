using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers;

public static class EmployeeEndpoints
{
    public static void MapEmployeeEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Employee", async (WebApplication1Context db) =>
        {
            return await db.Employee.ToListAsync();
        })
        .WithName("GetAllEmployees");

        routes.MapGet("/api/Employee/{id}", async (int RollNo, WebApplication1Context db) =>
        {
            return await db.Employee.FindAsync(RollNo)
                is Employee model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetEmployeeById");

        routes.MapPut("/api/Employee/{id}", async (int RollNo, Employee employee, WebApplication1Context db) =>
        {
            var foundModel = await db.Employee.FindAsync(RollNo);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateEmployee");

        routes.MapPost("/api/Employee/", async (Employee employee, WebApplication1Context db) =>
        {
            db.Employee.Add(employee);
            await db.SaveChangesAsync();
            return Results.Created($"/Employees/{employee.RollNo}", employee);
        })
        .WithName("CreateEmployee");

        routes.MapDelete("/api/Employee/{id}", async (int RollNo, WebApplication1Context db) =>
        {
            if (await db.Employee.FindAsync(RollNo) is Employee employee)
            {
                db.Employee.Remove(employee);
                await db.SaveChangesAsync();
                return Results.Ok(employee);
            }

            return Results.NotFound();
        })
        .WithName("DeleteEmployee");
    }
}
