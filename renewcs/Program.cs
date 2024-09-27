using System.Reflection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

using common.db;
using MySqlConnector;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using domain.admin;
using Microsoft.AspNetCore.Identity;
using common.config.inject;


var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

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
        string defaultConnectionStr = config.GetConnectionString("DefaultConnection")!;
        var connBuilder = new MySqlConnectionStringBuilder(defaultConnectionStr);
        connBuilder.UserID = config["user"];
        connBuilder.Password = config["password"];

        string connectionString = connBuilder.ConnectionString;
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
);

// 유저 생성을 위한 조건(아이디, 비밀번호 등) 설정
builder.Services.AddIdentity<AdminUser, IdentityRole>(options => {
    // 최소 10자, 특문 및 숫자 포함
    options.Password.RequiredLength = 10;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireDigit = true;
    options.User.RequireUniqueEmail = true;
})
// efcore 지원
.AddEntityFrameworkStores<AppDbContext>();

// 인증 방식 설정
builder.Services
.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        // ValidIssuer = config["JwtSettings:Issuer"],
        // ValidAudience = config["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtSettings:Key"]!)),
        // ValidateIssuer = true,
        // ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
    };
});
// DI 정의
InjectConfig.Config(builder);

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
