using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ObserverDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    public class ProductCreatedEventSendSmsHandler : IProductObserver
    {

        private readonly IServiceProvider _serviceProvider;


        public ProductCreatedEventSendSmsHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void ProductCreated(Product notification)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<ProductCreatedEventSendSmsHandler>>();
            logger.LogInformation($"Sms Gönderildi : Ürün id={notification.ProductId} Ürün ismi : {notification.ProductName}");
        }
    }
}
