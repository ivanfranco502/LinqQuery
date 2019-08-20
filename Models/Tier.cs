using System.Collections.Generic;

namespace LinqQuery.Models
{
    public class Tier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Signal> Signals { get; set; }
    }
}