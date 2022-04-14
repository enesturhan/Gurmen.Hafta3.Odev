using ObserverDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    public interface IProductObserver
    {
        void ProductCreated(Product notification);


    }
}
