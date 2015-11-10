using DataAccessLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implementation
{
    public class AlarmRepository : IRepository<Alarm>
    {
        public async Task Create(Alarm item)
        {
            using (var database = new AlarmWebServiceEntities())
            {
                database.Alarms.Add(item);
            }
        }
        
        public List<Alarm> ReadAsync()
        {
            using (var database = new AlarmWebServiceEntities())
            {
                return database.Alarms.OrderBy(x => x.Name).ToList();
            }
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
