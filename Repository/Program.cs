using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PeopleContext>();
builder.Services.AddScoped<PeopleRepository>();
builder.Services.AddSingleton<IMemoryCache, MemoryCache>();
builder.Services.AddScoped<IPeopleRepository, CachedPeopleRepository>();

var app = builder.Build();


app.MapGet("/", ([FromServices] IPeopleRepository repo) => repo.Get());
app.MapGet("/{id}", ([FromServices] IPeopleRepository repo, Guid id) => repo.GetById(id));


app.UseHttpsRedirection();
app.Run();
