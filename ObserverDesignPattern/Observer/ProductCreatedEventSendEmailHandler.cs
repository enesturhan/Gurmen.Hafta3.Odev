using Microsoft.Extensions.Logging;
using ObserverDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ObserverDesignPattern.Observer
{
    public class ProductCreatedEventSendEmailHandler : IProductObserver



    {
        private readonly IServiceProvider _serviceProvider;

        public ProductCreatedEventSendEmailHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ProductCreated(Product notification)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<ProductCreatedEventSendEmailHandler>>();
            logger.LogInformation($"Email Gönderildi : Ürün id={notification.ProductId} Ürün ismi : {notification.ProductName}");
        }
    }
}
