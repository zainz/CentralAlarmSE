using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Utility;
using Utility.DataTransferObjects;

namespace DataAccessLayer.Gateways
{
    public class AlarmGateway : AbstractGateway
    {
        public List<Alarm> AllAlarms()
        {
            return GetClient().GetAsync("api/alarm").Result.Content.ReadAsAsync<List<Alarm>>().Result;
        }
    }
}