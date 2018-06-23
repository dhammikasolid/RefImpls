using System;
using System.Collections.Generic;

namespace API
{
    public class ValueSerive
    {
        IValuesRepository valuesRepository;

        public ValueSerive(IValuesRepository valuesRepository)
        {
            this.valuesRepository = valuesRepository;
        }

        public IEnumerable<Value> Get()
        {
            return valuesRepository.Get(); 
        }

        public string Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}