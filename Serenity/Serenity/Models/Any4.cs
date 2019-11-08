using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serenity.Models
{
    public class Any4
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public List<Any> Bases { get; set; }

        //ManyToMany
        public List<AnyAny4> AnyAnies4 { get; set; }
    }
}
