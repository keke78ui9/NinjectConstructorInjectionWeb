using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace NinjectConstructorInjectionWeb
{
    public class Test
    {
        private readonly ISamurai _samurai;

        public Test()
        { 
        }

        [Inject]
        public Test(ISamurai samurai)
        {
            _samurai = samurai;
        }

        public string Attack()
        {
            return _samurai.GetData();
        }
    }
}
