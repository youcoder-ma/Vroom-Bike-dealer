using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vroom.Extension
{
    public class TillDate:RangeAttribute
    {
        public TillDate(int startYear):base(startYear, DateTime.Today.Year)
        {
        }
    }
}
