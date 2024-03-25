using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Models.Application.ViewModels
{
    public class PaginationResultViewModel <TEntity>
    {
        public required List<TEntity> Entities { get; set; }
        public int pageIndex { get; set; }
        
        public int TotalPagesCount { get; set; }
    }
}
