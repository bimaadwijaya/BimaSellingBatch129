using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selling.Model
{
    class SellingData
    {
        public string ProvinceName { get; set; }
        public string CreatedBy { get; set; }
        public int CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
