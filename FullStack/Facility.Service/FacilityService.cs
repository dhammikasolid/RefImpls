using Facility.Data;
using System.Collections.Generic;
using System.Linq;

namespace Facility.Service
{
    using Domain;

    public class FacilityService
    {
        FacilityContext context;

        public FacilityService(FacilityContext context)
        {
            this.context = context;
        }

        public IEnumerable<Facility> GetAll()
        {
            return context.Facilities.ToList();
        }
    }
}
