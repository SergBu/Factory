using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Middleware1 : IMiddleware
    {
        //специфические реализации онтерфейсного метода
        void IMiddleware.DoAction()
        {
            Console.WriteLine("Middleware1 do action");
        }
    }
}
