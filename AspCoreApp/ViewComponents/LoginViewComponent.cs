﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreApp.ViewComponents
{
    public class LoginViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

           return View();
        }
    }
}
