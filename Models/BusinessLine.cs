using System.Collections.Generic;

namespace LinqQuery.Models
{
    public class BusinessLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Tier> Tiers { get; set; }
    }
}