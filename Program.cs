using Microsoft.EntityFrameworkCore;
using ValeAtivos32427421.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=ValeAtivos32427421.db"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // MapOpenApi: Mapeia endpoints OpenAPI (nova versão do Swagger)
    app.MapOpenApi();
    
    // UseSwagger: Habilita o middleware do Swagger
    // UseSwaggerUI: Mostra a interface visual da API no navegador
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // SwaggerEndpoint: URL do arquivo JSON da API
        // RoutePrefix = string.Empty: Mostra Swagger na raiz (http://localhost:xxxx/)
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CacauShow API V1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
