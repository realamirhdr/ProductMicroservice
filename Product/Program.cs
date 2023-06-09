using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Reflection;
using Application;
using Application.Product.Command.CreateProduct;
using Application.Product.Query.GetAllProducts;
using Domain.Interfaces;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(typeof(MediatRAssembly).Assembly));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>(options =>
        options.UseSqlServer(builder.Configuration["ConnectionString"], b => b.MigrationsAssembly("Product")));


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
