using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TestForLink.Helper
{
    public class CustomConfig
    {
        public static int  PageSize {
            get
            {
                int size ;
                if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["pagesize"]) || !int.TryParse(ConfigurationManager.AppSettings["pagesize"],out size))
                {
                    return 30;
                }
                return size;
            }
        }
    }
}