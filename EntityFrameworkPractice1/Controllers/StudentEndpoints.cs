using Microsoft.EntityFrameworkCore;
using EntityFrameworkPractice1.Data;
using EntityFrameworkPractice1.Models;
namespace EntityFrameworkPractice1.Controllers;

public static class StudentEndpoints
{
    public static void MapStudentEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Student", async (EntityFrameworkPractice1Context db) =>
        {
            return await db.Student.ToListAsync();
        })
        .WithName("GetAllStudents");

        routes.MapGet("/api/Student/{id}", async (int RollNo, EntityFrameworkPractice1Context db) =>
        {
            return await db.Student.FindAsync(RollNo)
                is Student model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetStudentById");

        routes.MapPut("/api/Student/{id}", async (int RollNo, Student student, EntityFrameworkPractice1Context db) =>
        {
            var foundModel = await db.Student.FindAsync(RollNo);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateStudent");

        routes.MapPost("/api/Student/", async (Student student, EntityFrameworkPractice1Context db) =>
        {
            db.Student.Add(student);
            await db.SaveChangesAsync();
            return Results.Created($"/Students/{student.RollNo}", student);
        })
        .WithName("CreateStudent");

        routes.MapDelete("/api/Student/{id}", async (int RollNo, EntityFrameworkPractice1Context db) =>
        {
            if (await db.Student.FindAsync(RollNo) is Student student)
            {
                db.Student.Remove(student);
                await db.SaveChangesAsync();
                return Results.Ok(student);
            }

            return Results.NotFound();
        })
        .WithName("DeleteStudent");
    }
}
