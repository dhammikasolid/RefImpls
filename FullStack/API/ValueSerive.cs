using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class ValueSerive
    {
        ValueStore valueStore;

        public ValueSerive(ValueStore valueStore)
        {
            this.valueStore = valueStore;
        }

        public IEnumerable<string> Get()
        {
            return valueStore.Get(); 
        }

        public string Get(int id)
        {
            return valueStore.Get(id);
        }
    }
}