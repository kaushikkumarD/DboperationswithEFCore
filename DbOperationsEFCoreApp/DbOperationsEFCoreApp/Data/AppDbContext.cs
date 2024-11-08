using Microsoft.EntityFrameworkCore;

namespace DbOperationsEFCoreApp.Data
{
    public class AppDbContext :DbContext
    {
        //Construction
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
        }

        //Override ModelBuilder to Insert Records into specific Tables

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
                    new Currency() { Id = 2,CurrencyName="Pound",Description="GBP"},
                    new Currency() { Id = 3,CurrencyName="Dollar",Description="USA Dollar"},
                    new Currency() { Id = 4, CurrencyName = "Euro", Description = "Euro" }
                );
        }
        //Let know EF about tables to create
        public DbSet<Book> Books{ get; set; }
        public DbSet<BookPrice> BookPrices{ get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Currency> Currencies{ get; set; }
    }
}
