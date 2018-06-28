using System.Collections.Generic;

namespace Shared
{
    public interface IReadRepository<T> 
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}
