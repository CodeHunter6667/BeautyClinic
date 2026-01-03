using BeautyClinic.Api.Commons;

var builder = WebApplication.CreateBuilder(args);
builder.AddConfigurations();
builder.AddDbContext();
builder.AddRepositories();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
