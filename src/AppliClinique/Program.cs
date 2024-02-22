using Clinique.Data.Abstractions;
using Clinique.Data.Implementations;
using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;

var builder = WebApplication.CreateBuilder();
// Injection de Dependence 
builder.Services.AddTransient<IPatientRepository, PatientRepository>();
builder.Services.AddTransient<IPatientService, PatientService>();

var app = builder.Build();  
app.Run();