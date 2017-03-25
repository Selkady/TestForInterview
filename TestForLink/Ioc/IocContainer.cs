using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Kady.Base.Strapping;

namespace TestForLink.Ioc
{
    public class IocContainer
    {
         private static IWindsorContainer _container;

        public static IWindsorContainer Container
        {
            get { return _container; }
        }


        public static void Setup()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());

            IoCStrapper.BootStrap(ref _container);
            WindsorControllerFactory controllerFactory = new WindsorControllerFactory(Container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);


        }
    }
}