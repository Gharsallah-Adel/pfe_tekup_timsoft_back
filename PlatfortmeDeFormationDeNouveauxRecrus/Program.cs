using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.FormationServise;
using PlatfortmeDeFormationDeNouveauxRecrus.FormationManagement.Repository;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Repository;
using PlatfortmeDeFormationDeNouveauxRecrus.ReclamationManagement.Service;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Repository;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.UserServices;
using PlatfortmeDeFormationDeNouveauxRecrus.Utils;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(
options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);


builder.Services.AddDbContext<DataBaseContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("Ef_Postgres_DB")));

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IDepartmentRepository, Departmentrepository>();
builder.Services.AddTransient<IDepartmentService, Departmentservice>();
builder.Services.AddTransient<IDocumentRepository, DocumentRepository>();
builder.Services.AddTransient<IDocumentService, DocumentService>();
builder.Services.AddTransient<IProjectRepository, ProjectRepository>();
builder.Services.AddTransient<IProjectService, ProjectService>();
builder.Services.AddTransient<IUtil, Util>();
builder.Services.AddTransient<IFormationRepository, FormationRepository>();
builder.Services.AddTransient<IFormationService, FormationService>();
builder.Services.AddTransient<ISousDepartmentService, SousDepartementService>();
builder.Services.AddTransient<ISousDepartmentRepository, SousDepartmentrepository>();
builder.Services.AddTransient<ICategorieService, CategorieService>();
builder.Services.AddTransient<ICategorieRepository,CategorieRepository>();
builder.Services.AddTransient<IPlanFormationRepository, PlanFormationRepository>();
builder.Services.AddTransient<IPlanFormationService, PlanFormationService>();
builder.Services.AddTransient<IReclamationRepository, ReclamationRepository>();
builder.Services.AddTransient<IReclamationService, ReclamationService>();
builder.Services.AddTransient<ISalleRepository, SalleRepository>();
builder.Services.AddTransient<ISalleService, SalleService>();
builder.Services.AddTransient<IBureauRepository, BureauRepository>();
builder.Services.AddTransient<IBureauService, BureauService>();




//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});


//JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("Jwt:key").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
//enable domain
builder.Services.AddCors(option =>
{
    option.AddPolicy("MyPolicy", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
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
app.UseCors("MyPolicy");

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
