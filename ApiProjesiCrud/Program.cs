using ApiProjesiCrud.Middlewares;
using ApiProjesiCrud.Repository;
using ApiProjesiCrud.Repository.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using ObserverDesignPattern.Observer;
using System.Data;
using System.Reflection;
using MediatR;
using ApiProjesiCrud.Repository.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ProductObserverSubject>(sp =>
{
    ProductObserverSubject productObserverSubject = new();

    productObserverSubject.RegisterObserver(new ProductCreatedEventSendEmailHandler(sp));
    productObserverSubject.RegisterObserver(new ProductCreatedEventSendSmsHandler(sp));
    return productObserverSubject;
});


builder.Services.AddScoped<IDbConnection>(sp => new NpgsqlConnection(builder.Configuration.GetConnectionString("Postgresql")));


builder.Services.AddScoped<IDbTransaction>(sp =>
{

    var connection = sp.GetRequiredService<IDbConnection>();
    connection.Open();
    return connection.BeginTransaction();


});
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGlobalExceptionMiddleware();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
