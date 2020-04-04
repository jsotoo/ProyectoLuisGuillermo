using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraDataAccess.Abstractions
{
    public interface DML<T>
    {
        Task<T> Add(T element);
        Task<T> Remove(T element);
        List<T> Get(T element);
    }
}
