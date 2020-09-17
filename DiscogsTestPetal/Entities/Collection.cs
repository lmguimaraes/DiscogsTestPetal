using System.Collections.Generic;

namespace DiscogsTestPetal.Models
{
    public class Collection
    {
        public Pagination Pagination { get; set; }
        public List<Releases> Releases { get; set; } 
    }
}
