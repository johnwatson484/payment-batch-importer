using PaymentBatchImporter.Builder.Abstract;
using PaymentBatchImporter.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Builder.Concrete
{
    public class BatchBuilder : IBatchBuilder
    {
        Batch batch = new Batch();

        public IBatchBuilder AddHeader(string[] batchHeader)
        {
            batch.Scheme = batchHeader[1];
            batch.Sequence = batchHeader[2];
            batch.Value = decimal.Parse(batchHeader[3]);
            return this;
        }

        public IBatchBuilder AddPaymentRequest(PaymentRequest paymentRequest)
        {
            batch.PaymentRequests.Add(paymentRequest);
            return this;
        }

        public virtual PaymentRequest CreatePaymentRequest()
        {
            return new PaymentRequest();
        }

        public virtual InvoiceLine CreateInvoiceLine()
        {
            return new InvoiceLine();
        }

        public Batch GetBatch()
        {
            return batch;
        }
    }
}
