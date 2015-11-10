using DataAccessLayer.Database;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Facade
    {
        private IRepository<Alarm> alarmRepository; 

        public IRepository<Alarm> GetAlarmRepository()
        {
            return alarmRepository ?? (alarmRepository = new AlarmRepository());
        }
    }
}
