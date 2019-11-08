using System;
using System.Collections.Generic;

namespace Serenity.Models
{
    public class Any3
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Any> Anies { get; set; }
    }
}