using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;

namespace NinjectConstructorInjectionWeb
{
    public class MyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISamurai>().To<Samurai>();
        }
    }
}
