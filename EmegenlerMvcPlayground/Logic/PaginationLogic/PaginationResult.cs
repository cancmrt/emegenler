using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmegenlerMvcPlayground.Logic.PaginationLogic
{
    public class PaginationResult
    {
        public long CurrentPage { get; set; }
        public long RangeSize { get; set; }
        public long TotalPageCount { get; set; }
        public long TotalRowCount { get; set; }
    }
}
