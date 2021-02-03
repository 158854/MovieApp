using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
