using PaymentBatchImporter.Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Builder.Abstract
{
    public interface IBatchBuilder
    {
        IBatchBuilder AddHeader(string[] batchHeader);

        IBatchBuilder AddPaymentRequest(PaymentRequest paymentRequest);

        PaymentRequest CreatePaymentRequest();

        InvoiceLine CreateInvoiceLine();

        Batch GetBatch();
    }
}
