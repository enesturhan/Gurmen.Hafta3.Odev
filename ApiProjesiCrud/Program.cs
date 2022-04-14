using Microsoft.Extensions.DependencyInjection;
using ObserverDesignPattern.Observer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//builder.Services.Configure<IServiceCollection>();

//
builder.Services.AddSingleton<ProductObserverSubject>(sp =>
{
    ProductObserverSubject productObserverSubject = new();

    productObserverSubject.RegisterObserver(new ProductCreatedEventSendEmailHandler(sp));
    productObserverSubject.RegisterObserver(new ProductCreatedEventSendSmsHandler(sp));
    return productObserverSubject;
});
    



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
