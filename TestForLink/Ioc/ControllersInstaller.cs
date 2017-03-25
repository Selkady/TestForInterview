using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;

namespace TestForLink.Ioc
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(AllTypes.FromThisAssembly()
              .Pick().If(t => t.Name.EndsWith("Controller"))
              .Configure(configurer => configurer.Named(configurer.Implementation.Name))
              .LifestylePerWebRequest());

        }
    }
}