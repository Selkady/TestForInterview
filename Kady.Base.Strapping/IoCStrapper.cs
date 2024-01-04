using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Kady.Base.DAL;
using Kady.Base.Interface.Repository;
using Kady.Base.Interface.Service;
using Kady.Base.Repository;
using Kady.Base.Service;

namespace Kady.Base.Strapping
{
    public class IoCStrapper
    {
        public static void BootStrap(ref IWindsorContainer container)
        {
            container.Register(Component.For<TestEntities>().ImplementedBy<TestEntities>().LifestylePerWebRequest());
            container.Register(Component.For<IEmpRepository>().ImplementedBy<EmpRepository>().LifestylePerWebRequest());
            container.Register(Component.For<IDeptRepository>().ImplementedBy<DeptRepository>().LifestylePerWebRequest());
            container.Register(Component.For<IDeptService>().ImplementedBy<DeptService>().LifestylePerWebRequest());
            container.Register(Component.For<IEmpService>().ImplementedBy<EmpService>().LifestylePerWebRequest());
            container.Register(Component.For<IEmpService>().ImplementedBy<EmpService>().LifestylePerWebRequest());

        }
    }
}
