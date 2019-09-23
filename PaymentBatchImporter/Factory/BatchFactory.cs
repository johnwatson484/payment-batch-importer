using PaymentBatchImporter.Builder.Abstract;
using PaymentBatchImporter.Builder.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Factory
{
    public class BatchFactory
    {
        public IBatchBuilder GetBatchBuilder(string scheme)
        {
            switch (scheme)
            {
                case "CS":
                    return new CSBatchBuilder();
                default:
                    return new BatchBuilder();
            }
        }
    }
}
