using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using WebApplication1.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string conn = "Server=localhost;Port=3306;Database=Sample;Uid=root;Pwd=root";
builder.Services.AddDbContext<Dbcontext>(options => options.UseMySql(conn, ServerVersion.Create(Version.Parse("8.0.32"), ServerType.MySql)));




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
