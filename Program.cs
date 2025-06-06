using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o DbContext com SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=funcionarios.db"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CadastroFuncionariosAPI", Version = "v1" });
});

// >>> Adiciona política de CORS <<<
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirFront",
        policy => policy
            .WithOrigins("http://127.0.0.1:5500") // endereço do Live Server
            .AllowAnyHeader()
            .AllowAnyMethod()
    );
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// >>> Ativa CORS antes do UseAuthorization <<<
app.UseCors("PermitirFront");

app.UseAuthorization();
app.MapControllers();
app.Run();
