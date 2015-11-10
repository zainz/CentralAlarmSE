using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Utility;
using Utility.DataTransferObjects;

namespace PresentationLayer.Gateways
{
    public class AlarmGateway : AbstractGateway
    {
        private static Uri uri = new Uri("http://localhost:63226/");

        public AlarmGateway() : base(uri)
        {

        }

        public List<AlarmDTO> AllAlarms()
        {
           
            return GetClient().GetAsync("api/alarm").Result.Content.ReadAsAsync<List<AlarmDTO>>().Result;
        }
    }
}