using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming.Basics
{
    public interface IDenemeClass
    {
        void DenemeMethod();
    }

    public class DenemeClass : IDenemeClass
    {
        [MyInterceptorAspect(Priority = 1)]
        public virtual void DenemeMethod()
        {
            Console.WriteLine("DenemeMethod body.");
        }

    }
}
