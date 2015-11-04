using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utility.DataTransferObjects;

namespace DataAccessLayer.Controllers
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
            return facade.GetAlarmRepository().ReadAsync().Result;
        }

        [HttpPost]
        [Route("api/alarm")] 
        public HttpResponseMessage Create(Alarm alarm)
        {
            facade.GetAlarmRepository().Create(alarm);

            var response = Request.CreateResponse(HttpStatusCode.Created, alarm);
            return response;
        }
    }
}
