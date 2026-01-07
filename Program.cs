
using HelloEnterpriseApi.Data;
using HelloEnterpriseApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Add controllers (MVC)
builder.Services.AddControllers();

// 🔹 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 In-memory database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("HelloEnterpriseDb"));

// 🔹 Dependency Injection
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
