using AspectOrientedProgramming.Core.Interceptor;
using AspectOrientedProgramming.Entities;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System.Reflection;

namespace AspectOrientedProgramming.TicketApp
{
    public class DefaultModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var proxyOptions = new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            };

            builder.RegisterType<Ticket>()
                .As<ITicket>()
                .EnableInterfaceInterceptors(proxyOptions)
                .SingleInstance();
        }
        }
}
