using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utility.DataTransferObjects;

namespace PresentationLayer.Models
{
    public class AlarmViewModel
    {
        public List<Alarm> AllAlarms { get; set; }
        public Alarm SelectedAlarm { get; set; }
    }
}