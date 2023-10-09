using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PeopleContext>();
builder.Services.AddScoped<PeopleRepository>();

var app = builder.Build();


app.MapGet("/", ([FromServices] PeopleRepository repo) => repo.Get());
app.MapGet("/{id}", ([FromServices] PeopleRepository repo, Guid id) => repo.GetById(id));


app.UseHttpsRedirection();
app.Run();
