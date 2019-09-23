using PaymentBatchImporter.Builder.Abstract;
using PaymentBatchImporter.Builder.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PaymentBatchImporter.Builder.Director
{
    public class BatchDirector
    {
        public void BuildBatch(IBatchBuilder batchBuilder, string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = null;
                PaymentRequest paymentRequest = null;

                while ((line = reader.ReadLine()) != null)
                {
                    var lineValues = line.Split('^');
                    var currentLineType = lineValues[0];

                    if(currentLineType == "B")
                    {
                        batchBuilder.AddHeader(lineValues);
                    }
                    else if(currentLineType == "H")
                    {
                        paymentRequest = batchBuilder.CreatePaymentRequest();
                        paymentRequest.AddHeader(lineValues);
                        batchBuilder.AddPaymentRequest(paymentRequest);
                    }
                    else if(currentLineType == "L")
                    {
                        InvoiceLine invoiceLine = batchBuilder.CreateInvoiceLine();
                        invoiceLine.AddValues(lineValues);
                        paymentRequest.AddInvoiceLine(invoiceLine);
                    }
                }
            }
        }
    }
}
