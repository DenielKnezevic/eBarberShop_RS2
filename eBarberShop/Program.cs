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
