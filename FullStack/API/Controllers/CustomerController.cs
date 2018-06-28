using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{
    using Customers;

    public class CustomerController : ApiController
    {
        CustomerSerive customerService;

        public CustomerController(CustomerSerive customerService)
        {
            this.customerService = customerService;
        }

        // GET api/values
        public IEnumerable<Customer> Get()
        {
            return customerService.GetAll();
        }

        // GET api/values/5
        public Customer Get(int id)
        {
            return customerService.Get(id);
        }

        // POST api/values
        public void Post([FromBody]Customer value)
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
