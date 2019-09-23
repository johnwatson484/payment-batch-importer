namespace PaymentBatchImporter.Builder.Product
{
    public class InvoiceLine
    {
        public string Description { get; set; }

        public decimal Value { get; set; }

        public virtual void AddValues(string[] values)
        {
            Description = values[1];
            Value = decimal.Parse(values[2]);
        }
    }
}