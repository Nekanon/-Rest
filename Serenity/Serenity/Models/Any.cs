using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serenity.Models
{
    public class Any
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //OnetoOne
        public virtual Any2 Stuff { get; set; }

        //OneToMany
        public Guid Any3Id { get; set; }
        public Any3 Grade {get; set;}
        
        //ManyToMany
        public List<AnyAny4> AnyAnies4 { get; set; }
    }
}
