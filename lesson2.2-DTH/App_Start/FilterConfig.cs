﻿using System.Web;
using System.Web.Mvc;

namespace lesson2._2_DTH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
