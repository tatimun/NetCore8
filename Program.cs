using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint para verificar si la app está corriendo
app.MapGet("/health", () => Results.Ok(new { status = "Healthy", timestamp = DateTime.UtcNow }));

// Otro endpoint de prueba
app.MapGet("/", () => "¡Hola, Tati! Esta es una API en .NET 8 desplegada en Azure Web App Y aca hubo cambiossss 🎉");

app.Run();
