﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Utility;
using Utility.DataTransferObjects;

namespace BusinessLogicLayer.Gateways
{
    public class AlarmGateway : AbstractGateway
    {
        static Uri uri = new Uri("http://localhost:54362/");

        public AlarmGateway() : base(uri)
        {

        }

        public List<AlarmDTO> Read()
        {
            return GetClient().GetAsync("api/alarm").Result.Content.ReadAsAsync<List<AlarmDTO>>().Result;
        }

        public void Create(AlarmDTO alarm)
        {
            GetClient().PostAsJsonAsync("api/alarm", alarm);
        }
    }
}