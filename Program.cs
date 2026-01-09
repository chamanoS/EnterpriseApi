
using HelloEnterpriseApi.Data;
using HelloEnterpriseApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Dependency Injection

builder.Services.AddControllers(); // 🔹 Add controllers (MVC)
builder.Services.AddEndpointsApiExplorer();  // 🔹 Swagger
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>  // 🔹 In-memory database
    options.UseInMemoryDatabase("HelloEnterpriseDb"));

builder.Services.AddScoped<IPatientService, PatientService>();

var app = builder.Build();

// 🔹 Middleware pipeline for swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 🔹 Map controller routes
app.MapControllers();

app.Run();
