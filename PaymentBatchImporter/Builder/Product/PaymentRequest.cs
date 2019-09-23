using System.Collections.Generic;

namespace PaymentBatchImporter.Builder.Product
{
    public class PaymentRequest
    {
        public long FRN { get; set; }

        public decimal Value { get; set; }           

        public virtual IList<InvoiceLine> InvoiceLines { get; set; }

        public PaymentRequest()
        {
            InvoiceLines = new List<InvoiceLine>();
        }

        public void AddHeader(string[] header)
        {
            FRN = long.Parse(header[1]);
            Value = decimal.Parse(header[2]);
        }

        public void AddInvoiceLine(InvoiceLine invoiceLine)
        {
            InvoiceLines.Add(invoiceLine);
        }
    }
}