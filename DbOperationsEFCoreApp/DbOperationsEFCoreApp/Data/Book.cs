namespace DbOperationsEFCoreApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public int NoOfPages { get; set; }
        
        public bool IsActive { get; set; }
        
        public DateTime CreatedOn{ get; set; }

        public int LanguageId { get; set; } 

        // Map and Defined Foreign key Column - Table Name
        public Language Language { get; set; }


        // Map and Defined Table name where Book table id Col will be foreign key
        public ICollection<BookPrice> BookPrices { get; set; }
    }
}
