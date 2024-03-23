using Microsoft.EntityFrameworkCore;
using API.Context;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

//configura contexto do SQL SERVER passando a conexão do appsettings
builder.Services.AddDbContext<AgendaContext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));


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
