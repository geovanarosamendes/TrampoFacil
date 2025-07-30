using TrampoFacil.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using FluentValidation.AspNetCore;
using TrampoFacil.Application.Validators.Usuario;
using DotNetEnv;
using TrampoFacil.API.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using TrampoFacil.API.Middlewares;
using TrampoFacil.Exceptions.AutenticacaoExceptions;
using TrampoFacil.Application.Validators;
using TrampoFacil.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Carrega variáveis de ambiente do .env
DotNetEnv.Env.Load();

// Swagger e Controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();



// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Configurações do JWT
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));
var jwtSettings = builder.Configuration.GetSection("Jwt").Get<JwtSettings>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
     .AddJwtBearer(options =>{options.TokenValidationParameters= new Microsoft.IdentityModel.Tokens.TokenValidationParameters
      {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,


        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(
            System.Text.Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"]))
      };

    // exceptions personalizadas
       options.Events = new JwtBearerEvents
       {
        OnMessageReceived = context =>
        {
            var endpoint = context.HttpContext.GetEndpoint();
            
            var allowAnonymous = endpoint?.Metadata?.GetMetadata<Microsoft.AspNetCore.Authorization.IAllowAnonymous>() != null;
            if (allowAnonymous)
            {
                return Task.CompletedTask;
            }

            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrEmpty(token))
            {
                throw new TokenAusente();
            }

            context.Token = token;
            return Task.CompletedTask;
        },

        OnAuthenticationFailed = context =>
        {
            throw new TokenInvalido();
        }
        
       };
    });



// Banco de dados
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));


// Validações com FluentValidation
builder.Services.AddValidatorsFromAssemblyContaining<UsuarioDTOValidator>();
builder.Services.AddFluentValidationAutoValidation();

// Injeção de dependências
builder.Services.AddDependencies();
builder.Services.AddScoped<TokenGeneratorService>();

var app = builder.Build();


// Swagger (dev only)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middlewares
app.UseExceptionMiddleware();   
app.UseAuthentication();
app.UseAuthorization();



app.MapControllers();


app.Run();


