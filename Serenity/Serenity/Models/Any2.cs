using System;

namespace Serenity.Models
{
    public class Any2
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public Guid AnyId { get; set; }
        public Any InstanceAny { get; set; }
    }
}