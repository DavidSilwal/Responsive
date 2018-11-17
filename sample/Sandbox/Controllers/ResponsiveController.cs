﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wangkanai.Detection;

namespace Sandbox.Controllers
{
    public class ResponsiveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Desktop(string returnUrl = null)
        {
            var preference = HttpContext.GetDevice();
            preference.Device = "desktop";
            HttpContext.SetDevice(preference);
            return RedirectToLocal(returnUrl);
        }

        public IActionResult Mobile(string returnUrl = null)
        {
            var responsive = HttpContext.Responsive();
            var preference = HttpContext.GetDevice();
            preference.Device = "mobile";
            HttpContext.SetDevice(preference);
            return RedirectToLocal(returnUrl);
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}