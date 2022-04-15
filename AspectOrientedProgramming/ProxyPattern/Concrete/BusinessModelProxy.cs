using AspectOrientedProgramming.ProxyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.ProxyPattern
{
    /// <summary>
    /// proxy gercek bir nesneni yerine gecen bir yapı olarak düşünebilir.
    /// Kesişen endişelrin yönetimini saglamak icin
    /// decorater kalibi ile benzemektedir.
    /// Proxy aracı görevi görüyor.Client gercek objeye ulasmıyor proxyi ulasıyor proxy ilgili methodu calıstırıyor.
    /// 
    /// </summary>
    public class BusinessModelProxy : IBusinessModule
    {
        private readonly IBusinessModule _module;

        public BusinessModelProxy(IBusinessModule module)
        {
            _module = module;
        }

        public void Method()
        {
            Console.WriteLine("method oncesi");
            _module.Method();
            Console.WriteLine("method sonrası");
        }


    }

}
