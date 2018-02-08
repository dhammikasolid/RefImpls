using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Entity<T>
    {
        public T Id { get; set; }
    }
}