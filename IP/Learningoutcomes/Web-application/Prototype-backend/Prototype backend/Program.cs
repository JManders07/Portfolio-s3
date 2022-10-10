using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prototype_backend.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Prototype_backendContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Prototype_backendContext") ?? throw new InvalidOperationException("Connection string 'Prototype_backendContext' not found.")));
builder.Services.AddCors();
builder.Services.AddTransient<BeerService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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


app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});


app.MapControllers();

app.Run();
