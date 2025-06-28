using Microsoft.EntityFrameworkCore;
using Pelicula_Api_Test;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name=DefaultConnection")); 

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var dbContex = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

//    if (dbContex.Database.IsRelational())
//    {
//        dbContex.Database.Migrate();
//    }
//}

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
