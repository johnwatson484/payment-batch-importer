using PaymentBatchImporter.Builder.Abstract;
using PaymentBatchImporter.Builder.Director;
using PaymentBatchImporter.Builder.Product;
using PaymentBatchImporter.Factory;
using PaymentBatchImporter.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PaymentBatchImporter
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Batch> batches = new List<Batch>();
            string root = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).Parent.Parent.FullName;


            ImportService importService = new ImportService(new BatchDirector());
            batches.Add(importService.Import("BPS", Path.Combine(root, "Inbound", "BPS", "BPSBatchFile.txt")));
            batches.Add(importService.Import("CS", Path.Combine(root, "Inbound", "CS", "CSBatchFile.txt")));
            batches.Add(importService.Import("FDMR", Path.Combine(root, "Inbound", "FDMR", "FDMRBatchFile.txt")));
            batches.Add(importService.Import("DEL", Path.Combine(root, "Inbound", "Delinking", "DelinkingBatchFile.txt")));

            Console.WriteLine("All batches imported");
        }
    }
}
