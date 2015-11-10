using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utility.DataTransferObjects;

namespace PresentationLayer.Models
{
    public class AlarmViewModel
    {
        public List<AlarmDTO> AllAlarms { get; set; }
        public AlarmDTO SelectedAlarm { get; set; }
    }
}