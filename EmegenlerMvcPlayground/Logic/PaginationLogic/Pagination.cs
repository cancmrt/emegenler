using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmegenlerMvcPlayground.Logic.PaginationLogic
{
    public static class Pagination
    {
        public static PaginationResult Calculate(long TotalCount, long ChoosedPage, long RangeSize)
        {
            PaginationResult result = new PaginationResult();
            result.TotalRowCount = TotalCount;
            result.RangeSize = RangeSize;
            if(TotalCount <= RangeSize)
            {
                result.CurrentPage = 1;
                result.TotalPageCount = 1;
            }
            else if (TotalCount > RangeSize)
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
