using Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace API.Customers
{
    public class Customer : Entity
    {
        [Required]
        public string Name { get; set; }

        public static Customer Create()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var rand = new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return new Customer { Name = "Customer" + rand };
        }
    }
}