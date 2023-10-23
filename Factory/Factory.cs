using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Factory
    {
        public IMiddleware GetMiddleware(int type)
        {
            //фабрика в зависимости от условия создаёт экземпляр 
            //конкретного класса в зависимости от условия
            
            switch (type)
            {
                case 1:
                    return new Middleware1();

                case 2:
                default:
                    return new Middleware2();
            }
        }
    }
}
