using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class JobTitle
    {
        public int JobTitleID { get; set; }

        public string JobTitleName { get; set; }

        public string Major { get; set; }

        public decimal? PositionAllowance { get; set; }

        public int CoefficientsSalary { get; set; }

    }
}
