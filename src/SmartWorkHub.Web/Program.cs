using Microsoft.EntityFrameworkCore;
using SmartWorkHub.Infrastructure.Persistence;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SmartWorkHub.Domain.Interfaces;
using SmartWorkHub.Infrastructure.Repositories;
using MediatR;
using SmartWorkHub.Application.Features.Tasks.Commands;
var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register MediatR
builder.Services.AddMediatR(typeof(CreateTaskCommandHandler).Assembly);
// ✅ Add DbContext
builder.Services.AddDbContext<SmartWorkHubDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

// add repository to DI
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

// Add Cotrollers + swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
