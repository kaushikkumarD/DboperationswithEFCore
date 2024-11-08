namespace DbOperationsEFCoreApp.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public float Amount{ get; set; }
        public int CurrencyId { get; set; }

        // Map and Defined Foreign key Column - Table Name
        public Book Book { get; set; }
        public Currency Currency { get; set; }
    }
}
