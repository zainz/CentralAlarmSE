using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utility;
using Utility.DataTransferObjects;

namespace BusinessLogicLayer.Controllers
{
    public class AlarmsController : ApiController
    {
        private readonly Facade facade;

        public AlarmsController()
        {
            facade = new Facade();
        }

        [HttpGet]
        [Route("api/alarm")]
        public List<Alarm> Details()
        {
            return facade.GetAlarmGateway().AllAlarms();
        }
    }
}
