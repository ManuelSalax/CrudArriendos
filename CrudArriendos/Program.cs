using CrudArriendo.Application.UseCases.Dueno;
using CrudArriendo.Application.UseCases.DuenoU;
using CrudArriendo.Domain.Interfaces;
using CrudArriendo.Infrastucture.DataBase;
using CrudArriendo.Infrastucture.Repositories;
using CrudArriendos.Application.UseCases.DuenoU;

var builder = WebApplication.CreateBuilder(args);

// =============================
// 🧩 CONFIGURACIÓN DE SERVICIOS
// =============================

// Controladores API
builder.Services.AddControllers();

// Factoría de conexión a base de datos
builder.Services.AddSingleton<DbConnectionFactory>();

// Repositorio con cadena de conexión desde la fábrica
builder.Services.AddScoped<IDuenoRepository>(sp =>
{
    var factory = sp.GetRequiredService<DbConnectionFactory>();
    return new DuenoRepository(factory.GetConnectionString());
});

// Casos de uso (Use Cases)
builder.Services.AddScoped<CrearDuenoUseCase>();
builder.Services.AddScoped<ListarDuenosUseCase>();
builder.Services.AddScoped<ActualizarDuenoUseCase>();
builder.Services.AddScoped<EliminarDuenoUseCase>();
builder.Services.AddScoped<ObtenerDuenoPorIdUseCase>();

// =============================
// 🚀 CONSTRUCCIÓN DE LA APP
// =============================
var app = builder.Build();

// =============================
// ⚙️ MIDDLEWARES
// =============================

// Redirección a HTTPS
app.UseHttpsRedirection();
app.UseAuthorization();

// Servir el front desde wwwroot o Pages
app.UseDefaultFiles(); // Busca index.html por defecto
app.UseStaticFiles();

// Mapear controladores
app.MapControllers();

// Ejecutar la aplicación
app.Run();
