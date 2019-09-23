using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Builder.Product
{
    public class Batch
    {
        public string Scheme { get; set; }

        public string Sequence { get; set; }

        public decimal Value { get; set; }

        public virtual IList<PaymentRequest> PaymentRequests { get; set; }

        public Batch()
        {
            PaymentRequests = new List<PaymentRequest>();
        }
    }
}
