var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

// Sensor data endpoint
app.MapGet("/sensor", () =>
{
    var random = new Random();

    var sensorData = new List<SensorData>
    {
        new SensorData
        {
        Timestamp = DateTime.Now,            // Current timestamp
        Temperature = random.Next(-20, 85),       // Random temperature between -20 and 85°C
        Pressure = random.Next(0, 35000)       // Random pressure between 0 and 35000 psi
        }
    };

    //return sensorData;
    return Results.Json(sensorData);
})
.WithName("GetSensorData")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

// Record for Sensor data
record SensorData
{
    public DateTime Timestamp { get; set; }
    public double Temperature { get; set; }
    public double Pressure { get; set; }
}
