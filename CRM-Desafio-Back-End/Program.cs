using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Mapping;
using CRM_Desafio_Back_End.Repositories.Movement;
using CRM_Desafio_Back_End.Repositories.Product;
using CRM_Desafio_Back_End.Repositories.User;
using CRM_Desafio_Back_End.Services.Movement;
using CRM_Desafio_Back_End.Services.Product;
using CRM_Desafio_Back_End.Services.User;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IMovementInterface, MovementService>();
builder.Services.AddScoped<IUserRespository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IMovementRepository, MovementRpository>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<AppDbContext>(options =>
          options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString"), npgsqlOptions =>
          {
              npgsqlOptions.EnableRetryOnFailure();
          }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
