using AspectOrientedProgramming.Core.Interceptor;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.Basics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<DenemeClass>(new MyInterceptorAspect());
            aspect.DenemeMethod();

            Console.WriteLine(new String('-', 50));

            var builder = new ContainerBuilder();
            builder.RegisterType<DenemeClass>()
                .As<IDenemeClass>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                })
                .InstancePerDependency();

            var container = builder.Build();
            var willBeIntercepted = container.Resolve<IDenemeClass>();
            willBeIntercepted.DenemeMethod();

            Console.ReadLine();
        }
    }
}
