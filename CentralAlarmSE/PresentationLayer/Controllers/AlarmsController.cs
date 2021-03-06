﻿using PresentationLayer.Gateways;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace PresentationLayer.Controllers
{
    public class AlarmsController : Controller
    {
        private AlarmGateway gateway = new AlarmGateway();

        // GET: Alarms
        public ActionResult Index()
        {
            var model = new AlarmViewModel { AllAlarms = gateway.AllAlarms() };
            return View(model);
        }
    }
}