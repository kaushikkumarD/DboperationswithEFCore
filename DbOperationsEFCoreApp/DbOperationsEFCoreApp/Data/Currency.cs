namespace DbOperationsEFCoreApp.Data
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string Description{ get; set; }

        // Map and Defined Table name where Currency table id Col will be foreign key
        public ICollection<BookPrice> bookPrices{ get; set; }
    }
}
