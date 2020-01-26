
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
