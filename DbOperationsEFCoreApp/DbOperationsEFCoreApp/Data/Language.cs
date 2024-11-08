namespace DbOperationsEFCoreApp.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }

        // Map and Defined Table name where Language table id Col will be foreign key
        public ICollection<Book>Books{ get; set; }
    }
}
