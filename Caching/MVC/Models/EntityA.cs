using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class EntityA : Entity<int>
    {
        public string Prop { get; set; }
    }
}