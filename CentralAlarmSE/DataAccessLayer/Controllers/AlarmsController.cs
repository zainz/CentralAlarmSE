using DataAccessLayer.Gateways;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace DataAccessLayer.Controllers
{
    public class AlarmsController : Controller
    {
        private AlarmGateway _gateway = new AlarmGateway();

        // GET: Alarms
        public ActionResult Index()
        {
            var model = new AlarmViewModel { AllAlarms = _gateway.AllAlarms() };
            return View();
        }
    }
}