using eBarberShop.Services.Database;
using eBarberShop.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<eBarberShopContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("eBarberShop")));

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
builder.Services.AddAutoMapper(typeof(IDrzavaService));

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
