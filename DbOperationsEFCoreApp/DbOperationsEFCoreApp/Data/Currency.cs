namespace DbOperationsEFCoreApp.Data
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string Description{ get; set; }

        public ICollection<BookPrice> bookPrices{ get; set; }
    }
}
