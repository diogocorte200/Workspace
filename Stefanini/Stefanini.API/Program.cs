using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Stefanini.Infrastructure;
using Stefanini.Services.IRepositories;
using Stefanini.Services.IServices;
using Stefanini.Services.Repositories;
using Stefanini.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<ProdutoService>();



builder.Services.AddScoped<IItensPedidoRepository, ItensPedidoRepository>();
builder.Services.AddTransient<ItensPedidoService>();


builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddTransient<PedidoService>();


builder.Services.AddScoped<IItensPedidoRepository, ItensPedidoRepository>();
builder.Services.AddScoped<IItensPedidoService, ItensPedidoService>();

//builder.Services.AddAutoMapper(typeof(Startup));



builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
