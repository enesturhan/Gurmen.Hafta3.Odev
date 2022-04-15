using AspectOrientedProgramming.Core.Interceptor;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.Basics
{
    /// <summary>
    /// .Net üzerinde run time sırasında proxy tanımlamayı saglayan bir teknoloji.
    /// Hafif proxyler olusturmak icin kullanılan teknoloji
    /// Virtual ifadesi burada önemli noktadır.
    /// </summary>
  
    public class MyInterceptorAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Before {0}", invocation.Method);
        }

        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After {0}", invocation.Method);
        }

    }
}
