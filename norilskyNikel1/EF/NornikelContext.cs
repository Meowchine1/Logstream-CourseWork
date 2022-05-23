using Microsoft.EntityFrameworkCore;
namespace norilskyNikel1.EF
{
    public class NornikelContext : DbContext
    {
        public DbSet<Metal> metal { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Brilliant> brilliants { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WIN-QGN772BFJ6Q\MYSQL;Database=City1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Metal>().HasData(

                 new Metal[]
                {
                     new Metal { Id = 1, name = "Yrilski Palalladiy", description = ""},
                    new Metal { Id = 12, name = "Russian gold", description = ""},
                    new Metal { Id = 13, name = "Serebro", description = ""},
                    new Metal { Id = 14, name = "", description = ""},
                }
                );

            modelBuilder.Entity<Brilliant>().HasData(

                new Brilliant[]
                {
                    new Brilliant {Id = 15, name = "", description = ""},
                    new Brilliant {Id = 16, name = "", description = ""},
                    new Brilliant {Id = 17, name = "", description = ""},
                    new Brilliant {Id = 18, name = "", description = ""},,
                    new Brilliant {Id = 19, name = "", description = ""},
                }

                );

            modelBuilder.Entity<ProductCategory>().HasData(
                
                new ProductCategory[]
                { 
                    new ProductCategory { Id = 20, Name = "Expensive stones" },
                    new ProductCategory { Id = 21, Name = "Colorful metal" },
                
                }

                );
        }

        public void CreateIfNotExist()
        {
            Database.EnsureCreated();

        }
    }
}
