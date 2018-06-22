using System.Collections.Generic;

namespace API
{
    public interface IValuesRepository
    {
        IEnumerable<Value> Get();
    }
}
