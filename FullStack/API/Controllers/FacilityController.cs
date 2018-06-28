using System.Collections.Generic;
using System.Web.Http;
using Facility.Service;

namespace API.Controllers
{
    using Facility.Domain;

    public class FacilityController : ApiController
    {
        FacilityService facilityService;

        public FacilityController(FacilityService facilityService)
        {
            this.facilityService = facilityService;
        }

        public IEnumerable<Facility> Get()
        {
            return facilityService.GetAll();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}