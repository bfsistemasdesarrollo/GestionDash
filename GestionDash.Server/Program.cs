using GestionDash.Server.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Registro de todos los servicios.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Conecta EF Core con SQL Server.
builder.Services.AddControllers(); // Habilita los API Controllers.
builder.Services.AddOpenApi();

var jwt = builder.Configuration.GetSection("Jwt");
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) // Configura la validación de JWT.
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwt["Issuer"],
            ValidAudience = jwt["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt["Key"]!))
        };
    });

var app = builder.Build();

// Sirven el frontend en producción.
app.UseDefaultFiles(); 
app.MapStaticAssets();

if (app.Environment.IsDevelopment())
    app.MapOpenApi();

app.UseHttpsRedirection();

// Valida el JWT en cada request.
app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers(); // Registra las rutas /api/*.

app.MapFallbackToFile("/index.html"); // SPA fallback para el router de React.

app.Run();
