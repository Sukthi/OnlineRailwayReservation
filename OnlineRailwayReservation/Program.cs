using Microsoft.EntityFrameworkCore;
using OnlineRailwayReservation.Models;
using OnlineRailwayReservation.Repositories;
using RailwayReservation.Models;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<RailwayReservationContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("RailwayReservationDb")));


builder.Services.AddScoped<IPassengerRepository<PassengerDetails>, SqlPassengerRepository>();
builder.Services.AddScoped<IPassengerRepository<TrainDetails>, TrainDetailsRepository>();
builder.Services.AddScoped<IPassengerRepository<Reservation>, ReservationRepository>();






builder.Services.AddSwaggerGen(options =>
{
    options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});
builder.Services.AddCors((options) =>
{
    options.AddPolicy("angularApplication", (builder) =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
        //.WithExposedHeaders("*");
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add configuration setup
builder.Configuration.AddJsonFile("appsettings.json");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("angularApplication");

app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();