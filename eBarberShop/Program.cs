using eBarberShop.Auth;
using eBarberShop.Services.Database;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme , Id = "basicAuth"}
            },
            new string[]{}
        }
    });
});

builder.Services.AddDbContext<eBarberShopContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("eBarberShop")));
builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
builder.Services.AddTransient<IDrzavaService,DrzavaService>();
builder.Services.AddTransient<IGradService,GradService>();
builder.Services.AddTransient<IUlogaService,UlogaService>();
builder.Services.AddTransient<IUslugaService,UslugaService>();
builder.Services.AddTransient<IVrstaProizvodaService, VrstaProizvodaService>();
builder.Services.AddTransient<IProizvodService,ProizvodService>();
builder.Services.AddTransient<IKorisnikService, KorisnikService>();
builder.Services.AddTransient<ITerminService, TerminService>();
builder.Services.AddTransient<ISlikaService, SlikaService>();
builder.Services.AddTransient<IRecenzijaService,RecenzijaService>();
builder.Services.AddTransient<INovostService, NovostService>();
builder.Services.AddTransient<IProizvodService, ProizvodService>();
builder.Services.AddTransient<INarudzbaService,NarudzbaService>();
builder.Services.AddTransient<IRezervacijaService, RezervacijaService>();
builder.Services.AddAutoMapper(typeof(IDrzavaService));

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
