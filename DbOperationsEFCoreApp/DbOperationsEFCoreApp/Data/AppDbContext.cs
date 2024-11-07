using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                    new Language() { Id=1,Title="Hindi",Description="Hindi"},
                    new Language() { Id=2,Title="English",Description="English"},
                    new Language() { Id=3,Title="Telugu",Description="Telugu"},
                    new Language() { Id=4,Title="Gujarati",Description="Gujarati"}
                );
            modelBuilder.Entity<Currency>().HasData(
                    new Currency() { Id = 1,CurrencyName="INR",Description="Indian INR"},
                    new Currency() { Id = 2,CurrencyName="GBP",Description="UK GBP"},
                    new Currency() { Id = 3,CurrencyName="USD",Description="USA Dollor"}
                );
        }
        public DbSet<Book> Books{ get; set; }
        public DbSet<BookPrice> BookPrices{ get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Currency> Currencies{ get; set; }
    }
}
