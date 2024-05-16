using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using TestApi.Models;
using TestApi.Repository;
using TestApi.Services;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppSettings>(Configuration);
builder.Services.AddSingleton<ISqlConnectionInformation>(new SqlConnectionInformation(Settings.appSettings));


builder.Services.AddTransient<IService<BKTest>, BKTestService>();
builder.Services.AddTransient<IRepository<BKTest>, BKTestRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
