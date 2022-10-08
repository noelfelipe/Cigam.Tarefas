using Cigam.Tarefas.Application.Features.Tarefas.Models.AddTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.EditTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Models.GetAllTarefa;
using Cigam.Tarefas.Application.Features.Tarefas.Repository;
using Cigam.Tarefas.Application.Features.Tarefas.Repository.Interface;
using Cigam.Tarefas.Models;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(typeof(TarefaAddInput).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(TarefaEditInput).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllTarefaInput).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetTarefaByIdInput).GetTypeInfo().Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
