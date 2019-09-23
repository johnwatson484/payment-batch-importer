using PaymentBatchImporter.Builder.Abstract;
using PaymentBatchImporter.Builder.Director;
using PaymentBatchImporter.Builder.Product;
using PaymentBatchImporter.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentBatchImporter.Services
{
    class ImportService
    {
        BatchDirector batchDirector;

        public ImportService(BatchDirector batchDirector)
        {
            this.batchDirector = batchDirector;
        }

        public Batch Import(string scheme, string filePath)
        {
            IBatchBuilder batchBuilder = new BatchFactory().GetBatchBuilder(scheme);
            batchDirector.BuildBatch(batchBuilder, filePath);
            return batchBuilder.GetBatch();
        }
    }
}
