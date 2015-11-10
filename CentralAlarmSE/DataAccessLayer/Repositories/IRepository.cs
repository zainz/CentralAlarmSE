using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T>
    {
        Task Create(T item);
        List<T> ReadAsync();
        Task<T> ReadAsync(Guid guid);
        Task<T> Delete(T item);
    }
}
