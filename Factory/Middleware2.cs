using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Middleware2 : IMiddleware
    {
        void IMiddleware.DoAction()
        {
            Console.WriteLine("Middleware2 do action");
        }
    }
}
