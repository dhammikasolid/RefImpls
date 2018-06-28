using Shared;
using System.ComponentModel.DataAnnotations;

namespace Facility.Domain
{
    public class Item : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}