using Microsoft.EntityFrameworkCore;
using shopping.Models;

namespace shopping.Data
{
    public class NorthwindContext : DbContext

    {
        //Constructor
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }
        public NorthwindContext() { }

        public DbSet<Product> product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapping + จัดการ relations
            modelBuilder.Entity<Product>().ToTable("product");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server = "localhost";
            string database = "my_db";
            string uid = "root";
            string password = "12345678";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";PORT=3306;SslMode=Required;";
            optionsBuilder.UseMySQL(connectionString);
        }

    }
}
