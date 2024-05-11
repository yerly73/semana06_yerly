using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int invoice_id { get; set; }
        public int customer_id { get; set; }
        public DateTime date { get; set; }
        public decimal total { get; set; }
        public string active { get; set; }
    }
}
