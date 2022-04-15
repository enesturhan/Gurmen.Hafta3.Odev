using AspectOrientedProgramming.ProxyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.ProxyPattern.Concrete
{
    internal class BusinessModel : IBusinessModule
    {
        public void Method()
        {
            Console.WriteLine("Methoda");
        }
    }
}
