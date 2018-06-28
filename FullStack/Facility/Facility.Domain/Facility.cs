using Shared;
using System.ComponentModel.DataAnnotations;

namespace Facility.Domain
{
    public class Facility : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}