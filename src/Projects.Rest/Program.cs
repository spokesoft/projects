var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};


// Create a single project
app.MapPost("/projects", (ProjectCreateForm form) => {});
// Create a range of projects
app.MapPut("/projects", (IEnumerable<ProjectCreateForm> forms) => {});
// Find a single project
// Search for projects
app.MapGet("/projects", () => {});
// Update a single project
// Update a range of projects
app.MapPatch("/projects", (IEnumerable<ProjectUpdateForm> forms) => {});
// Delete a single project




app.MapGet("/projects/{id}", (long id) => {}); // Return project with given id
app.MapPost("/projects/{id}", (long id, ProjectUpdateForm form) => {}); // Update project with given id
app.MapDelete("/projects/{id}", (long id) => {}); // Delete project with given id

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

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}


internal class Project {};
internal class ProjectCreateForm {};
internal class ProjectUpdateForm {};
internal class ProjectDeleteForm {};