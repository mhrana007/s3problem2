using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.DataContext;
using BusinessLogicLayer.Interface;
using Microsoft.EntityFrameworkCore;
using BusinessLogicLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<S3DbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sql"));
});
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IBuildingService, BuildingService>();
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

app.MapControllers();

app.Run();
