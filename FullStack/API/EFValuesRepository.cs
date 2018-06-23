using System.Collections.Generic;
using System.Linq;

namespace API
{
    public class EFValuesRepository : IValuesRepository
    {
        ValuesContext valuesContext;

        public EFValuesRepository(ValuesContext valuesContext)
        {
            this.valuesContext = valuesContext;
        }

        public IEnumerable<Value> Get()
        {
            return valuesContext.Values.ToList();
        }
    }
}