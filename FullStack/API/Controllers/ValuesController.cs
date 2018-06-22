﻿using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        ValueSerive valueSerive;

        public ValuesController(ValueSerive valueSerive)
        {
            this.valueSerive = valueSerive;
        }

        // GET api/values
        public IEnumerable<Value> Get()
        {
            return valueSerive.Get();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return valueSerive.Get(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
