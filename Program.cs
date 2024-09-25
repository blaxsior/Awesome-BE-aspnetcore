using System.Reflection;
using Microsoft.EntityFrameworkCore;

using common.db;
using MySqlConnector;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// swagger 설정
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{

    // swagger XML 주석 반영
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

// efcore 연결 설정
builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        string defaultConnectionStr = builder.Configuration.GetConnectionString("DefaultConnection")!;
        var connBuilder = new MySqlConnectionStringBuilder(defaultConnectionStr);
        connBuilder.UserID = builder.Configuration["user"];
        connBuilder.Password = builder.Configuration["password"];

        string connectionString = connBuilder.ConnectionString;
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
);

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
