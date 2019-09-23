using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Builder.Product
{
    public class CSInvoiceLine : InvoiceLine
    {
        public string SchemeCode { get; set; }

        public override void AddValues(string[] values)
        {
            base.AddValues(values);
            SchemeCode = values[3];
        }
    }
}
