using Microsoft.EntityFrameworkCore;
using FluentApi.Entities;
using FluentApi;
using BusinessLogic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var obj = builder.Configuration.GetConnectionString("dbconn");

builder.Services.AddDbContext<AppointmentDbContext>(options => options.UseSqlServer(obj));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IRepo<FluentApi.Entities.Appointment>, AppointmentRepo>();
builder.Services.AddScoped<ILogic, Logic>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
