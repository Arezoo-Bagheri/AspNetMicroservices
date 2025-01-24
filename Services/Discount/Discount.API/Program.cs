using Discount.API.Data;
using Discount.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<DiscountContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Discount.API",
        Version = "v1"
    });
});


var app = builder.Build();
app.UseMigration();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Discount.API V1");
    options.RoutePrefix = string.Empty; // To serve Swagger UI at root
});

app.UseAuthorization();

app.MapControllers();

app.Run();
