using EFCore6.Core.Repositories;
using EFCore6.Core.Servics.Implemetations;
using EFCore6.Core.Servics.Interfaces;
using EFCore6.Infra;
using EFCore6.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddDbContext<PubContext>(op => op.UseSqlServer());
builder.Services.AddControllers();

builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IPubContextUnitOfWork, PubContextUnitOfWork>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
