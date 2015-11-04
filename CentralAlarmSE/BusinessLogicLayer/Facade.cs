using BusinessLogicLayer.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLogicLayer
{
    public class Facade
    {
        private AlarmGateway alarmGateway;

        public AlarmGateway GetAlarmGateway()
        {
            return alarmGateway ?? (alarmGateway = new AlarmGateway());
        }
    }
}