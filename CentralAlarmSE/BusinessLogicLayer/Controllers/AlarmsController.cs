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
        public List<AlarmDTO> Details()
        {
            return facade.GetAlarmGateway().Read();
        }

        [HttpPost]
        [Route("api/alarm")]
        public void Create(AlarmDTO alarm)
        {
            facade.GetAlarmGateway().Create(alarm);
        }
    }
}
