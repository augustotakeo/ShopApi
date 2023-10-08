using System;
using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Handlers;
using MediatR;
using MediatR.Pipeline;
using Domain.Repositories.Interfaces;
using Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddMediatR(cfg => { 
        cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
        cfg.RegisterServicesFromAssembly(typeof(UserHandler).Assembly);
    });
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
