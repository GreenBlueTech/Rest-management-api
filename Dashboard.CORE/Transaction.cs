using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.CORE
{
    public class Transaction
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public int CompanySymbol { get; set; }
    }
}
