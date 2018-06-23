using System.Collections.Generic;

namespace API
{
    public class ValueStore
    {
        List<string> values = new List<string> { "value1", "value2" };

        public IEnumerable<string> Get()
        {
            return values; 
        }

        public string Get(int id)
        {
            return values[id];
        }
    }
}