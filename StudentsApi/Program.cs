using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StudentsApi.Context;
using StudentsApi.Models;
using StudentsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<StudentDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IStudentService, StudentService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/GetAllStudents", async ([FromServices] IStudentService studentService) =>  await studentService.GetAllStudents());
app.MapGet("/GetStudentsByName", async ([FromServices] IStudentService studentService, [FromQuery]string name) => await studentService.GetStudentsByName(name));
app.MapGet("/GetStudentById", async ([FromServices] IStudentService studentService, [FromQuery]int Id) => await studentService.GetStudentById(Id)); // alter Id to int on props
app.MapPost("/CreateStudent", async ([FromBody] Student student, [FromServicesAttribute]  IStudentService studentService) => await studentService.CreateStudent(student));
app.MapPut("/UpdateStudent", async ([FromServices] IStudentService studentService, [FromBody] Student student) => await studentService.UpdateStudent(student));
app.MapDelete("/DeleteStudent", async ([FromServices] IStudentService studentService, [FromQuery] Guid id) => await studentService.DeleteStudent(id));



app.Run();


