
namespace EmegenlerMvcPlayground.Logic.PaginationLogic
{
    public static class Pagination
    {
        public static PaginationResult Calculate(long TotalCount, long ChoosedPage, long RangeSize)
        {
            PaginationResult result = new PaginationResult
            {
                TotalRowCount = TotalCount,
                RangeSize = RangeSize
            };
            if (TotalCount <= RangeSize)
            {
                result.CurrentPage = 1;
                result.TotalPageCount = 1;
            }
            else
            {
                long PageCount = TotalCount / RangeSize;
                if ((TotalCount % RangeSize) > 0)
                {
                    PageCount++;
                }
                result.TotalPageCount = PageCount;
                if(ChoosedPage > result.TotalPageCount)
                {
                    result.CurrentPage = PageCount;
                }
                else if(ChoosedPage < 1)
                {
                    result.CurrentPage = 1;
                }
                else
                {
                    result.CurrentPage = ChoosedPage;
                }
            }

            return result;
            
        }
    }
}
