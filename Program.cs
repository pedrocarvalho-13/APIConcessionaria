using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using APIConcessionaria;
using DotNetEnv;


var builder = WebApplication.CreateBuilder(args);

// Carregar as variáveis de ambiente do arquivo .env
Env.Load();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoDB")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
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

// Para iniciar o projeto é necessário realizar alguns comandos: 
// dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.7
// dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.4
// dotnet ef migrations add initDb
// dotnet ef database update
// dotnet watch run