using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblingTracker.Domain.Services
{
    public interface IDataServices<T>

    {
        Task<IEnumerable> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);



    }
}
