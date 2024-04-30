using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Filters
{
    public class FilterBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public FilterBase()
        {
            PageIndex = 1;
            PageSize = 10;
        }
    }
}
