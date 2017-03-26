using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kady.Base.Interface.Service;
using Microsoft.Owin.Security.Provider;
using TestForLink.Ioc;

namespace TestForLink.Helper
{
    public class SelectHelper
    {
        public static SelectList DeptSelectList()
        {
            return new SelectList(IocContainer.Container.Resolve<IDeptService>().GetAll(),"Id","Name"); 
        } 
    }
}