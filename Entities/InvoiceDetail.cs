﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class InvoiceDetail
    {
        public int invoicedetail_id { get; set; }
        public int invoice_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal subtotal { get; set; }
        public string active { get; set; }
    }
}
