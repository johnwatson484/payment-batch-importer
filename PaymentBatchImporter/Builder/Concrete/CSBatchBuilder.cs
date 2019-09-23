using PaymentBatchImporter.Builder.Abstract;
using PaymentBatchImporter.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Builder.Concrete
{
    public class CSBatchBuilder : BatchBuilder
    {
        public override InvoiceLine CreateInvoiceLine()
        {
            return new CSInvoiceLine();
        }
    }
}
