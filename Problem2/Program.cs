using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.DataContext;
using BusinessLogicLayer.Interface;
using Microsoft.EntityFrameworkCore;
using BusinessLogicLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;//json property names unchanged
}); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Database Connection
builder.Services.AddDbContext<S3DbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("sql"));
});
//Lifetime service register
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IReadingRepository, ReadingRepository>();
builder.Services.AddTransient<IBuildingService, BuildingService>();
builder.Services.AddTransient<IDataFieldService, DataFieldService>();
builder.Services.AddTransient<IObjectService, ObjectService>();
builder.Services.AddTransient<IReadingService, ReadingService>();
//services cors
builder.Services.AddCors(options =>
{
    //policy add
    options.AddPolicy("s3",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("s3");//app cors

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseAuthorization();

app.MapControllers();

app.Run();
