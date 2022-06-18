using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FoodAPI.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FoodAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodAPIContext")));

// Add services to the container.

builder.Services.AddCors(op =>
{
    op.AddDefaultPolicy(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

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

app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
