using ObserverDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    public class ProductObserverSubject
    {
        private readonly List<IProductObserver> _productObservers;

        public ProductObserverSubject()
        {
            _productObservers = new List<IProductObserver>();
        }

        public void RegisterObserver(IProductObserver productObserver)
        {
            _productObservers.Add(productObserver);
        }

        public void RemoveObserver(IProductObserver productObserver)
        {
            _productObservers.Remove(productObserver);
        }

        public void NotifyObserver(Product product)
        {
            _productObservers.ForEach(x =>
            {
                x.ProductCreated(product);
            });
        }
    }
}
