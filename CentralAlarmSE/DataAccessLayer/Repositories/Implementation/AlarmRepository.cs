using DataAccessLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.DataTransferObjects;

namespace DataAccessLayer.Repositories.Implementation
{
    public class AlarmRepository : IRepository<Alarm>
    {
        public Task Create(Alarm item)
        {
            using (var database = new AlarmWebServiceEntities())
            {
                return database.Alarms.FirstOrDefault(x => x.GUID == item.Guid);
            }
        }
        
        public Task<List<Alarm>> ReadAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Alarm> ReadAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<Alarm> Delete(Alarm item)
        {
            throw new NotImplementedException();
        }
    }
}
