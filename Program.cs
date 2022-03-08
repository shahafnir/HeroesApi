using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Serilog;
using Serilog.Events;
using HeroesApi.Configurations;
using HeroesApi.Data;
using HeroesApi.Models.IdentityModels;
using HeroesApi.Services.Heroes;
using HeroesApi.Services.Users;

Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateBootstrapLogger();

try
{
    Log.Information("Starting the web host");

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((context, services, configuration) => configuration
       .ReadFrom.Configuration(context.Configuration)
       .ReadFrom.Services(services)
       .Enrich.FromLogContext());

    // Add services to the container.
    builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
    {
        options.User.RequireUniqueEmail = true;
        options.SignIn.RequireConfirmedAccount = true;
        options.Password.RequiredLength = 8;
        options.Password.RequireDigit = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = true;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

    builder.Services
        .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(jwt =>
        {
            var key = Encoding.ASCII.GetBytes(builder.Configuration["JwtConfig:Secret"]);

            jwt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidIssuer = builder.Configuration["JwtConfig:Issuer"],
                ValidateAudience = true,
                ValidAudience = builder.Configuration["JwtConfig:Audience"]
            };
        });

    builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

    builder.Services.AddScoped<IUsersService, UsersService>();

    builder.Services.AddScoped<IHeroesService, HeroesService>();

    builder.Services.AddControllers();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    app.UseSerilogRequestLogging(configure =>
    {
        configure.MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000}ms";
    });

    app.UseCors(builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseExceptionHandler((exceptionHandlerApp) =>
    {
        exceptionHandlerApp.Run(async (context) =>
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            var pd = new ProblemDetails()
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "An unrecoverable error occured",
            };
            pd.Extensions.Add("requestId", context.TraceIdentifier);

            await context.Response.WriteAsJsonAsync(pd, pd.GetType());
        });
    });

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}

return 0;