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
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-NA2LFB37;Database=Nornikel;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Metal>().HasData(

                 new Metal[]
                {
                     new Metal { Id = 1, name = "Yrilski Palalladiy", 
                         description = "Palladium is a chemical element with the symbol Pd and atomic number 46." +
                         " It is a rare and lustrous silvery-white metal discovered in 1803 by the English chemist William Hyde Wollaston." +
                         " He named it after the asteroid Pallas, which was itself named after the epithet of the Greek goddess Athena," +
                         " acquired by her when she slew Pallas. Palladium, platinum, rhodium, ruthenium, iridium and osmium form a group" +
                         " of elements referred to as the platinum group metals (PGMs). They have similar chemical properties, but palladium " +
                         "has the lowest melting point and is the least dense of them."
                     , ProductCategoryId = 20},
                    new Metal { Id = 12, name = "Russian gold", 
                        description = "Gold is a chemical element with the symbol Au (from Latin: aurum) and atomic number 79, making " +
                        "it one of the higher atomic number elements that occur naturally. It is a bright, slightly orange-yellow, dense," +
                        " soft, malleable, and ductile metal in a pure form. Chemically, gold is a transition metal and a group 11 element. " +
                        "It is one of the least reactive chemical elements and is solid under standard conditions. Gold often occurs in free" +
                        " elemental (native) form, as nuggets or grains, in rocks, veins, and alluvial deposits."
                    , ProductCategoryId = 20},
                    new Metal { Id = 13, name = "Silver", 
                        description = "Silver is a chemical element with the symbol Ag (from the Latin argentum, derived from the Proto-Indo-European " +
                        "h₂erǵ: shiny or white) and atomic number 47. A soft, white, lustrous transition metal, it exhibits the highest electrical " +
                        "conductivity, thermal conductivity, and reflectivity of any metal.[4] The metal is found in the Earth's crust in the pure, " +
                        "free elemental form (native silver), as an alloy with gold and other metals, and in minerals such as argentite and chlorargyrite. "
                    },
                    new Metal { Id = 14, name = "Copper", 
                        description = "Copper is a chemical element with the symbol Cu (from Latin: cuprum) and atomic number 29. It is a soft," +
                        " malleable, and ductile metal with very high thermal and electrical conductivity. A freshly exposed surface of pure copper " +
                        "has a pinkish-orange color. Copper is used as a conductor of heat and electricity, as a building material, and as a constituent" +
                        " of various metal alloys, such as sterling silver used in jewelry, cupronickel used to make marine hardware and coins, and " +
                        "constantan used in strain gauges and thermocouples for temperature measurement."
                    , ProductCategoryId = 20},
                    new Metal { Id = 25, name = "Cobalt",
                        description = "Cobalt is a chemical element with the symbol Co and atomic number 27. As with nickel, cobalt is found in the " +
                        "Earth's crust only in a chemically combined form, save for small deposits found in alloys of natural meteoric iron. The free" +
                        " element, produced by reductive smelting, is a hard, lustrous, silver-gray metal."
                    , ProductCategoryId = 20},
                }
                );

            modelBuilder.Entity<Brilliant>().HasData(
                new Brilliant[]
                {
                    new Brilliant { Id = 16, name = "Type Ia",
                    description = "Type Ia diamonds make up about 95% of all natural diamonds." +
                    " The nitrogen impurities, up to 0.3% (3000 ppm), are clustered within the carbon lattice," +
                    " and are relatively widespread. The absorption spectrum of the nitrogen clusters can cause the " +
                    "diamond to absorb blue light, making it appear pale yellow or almost colorless. Most Ia diamonds " +
                    "are a mixture of IaA and IaB material; these diamonds belong to the Cape series, named after the " +
                    "diamond-rich region formerly known as Cape Province in South Africa, whose deposits are largely Type Ia."
                  , ProductCategoryId = 21},
                    new Brilliant { Id = 17, name = "Type IB",
                        description = "Type Ib make up about 0.1% of all natural diamonds. They contain up to 0.05% (500 ppm) " +
                        "of nitrogen, but the impurities are more diffuse, the atoms are dispersed throughout the crystal in isolated sites." +
                        " Type Ib diamonds absorb green light in addition to blue, and have a more intense or darker yellow or brown colour " +
                        "than Type Ia diamonds. The stones have an intense yellow or occasionally brown tint; the rare canary diamonds belong " +
                        "to this type, which represents only 0.1% of known natural diamonds. The visible absorption spectrum is gradual," +
                        " without sharp absorption bands.[4] Almost all HPHT synthetic diamonds are of Type Ib."
                   , ProductCategoryId = 21 },
                    new Brilliant { Id = 18, name = "Type IIa",
                        description = "Type IIa diamonds make up 1–2% of all natural diamonds (1.8% of gem diamonds). These diamonds are almost" +
                        " or entirely devoid of impurities, and consequently are usually colourless and have the highest thermal conductivity." +
                        " They are very transparent in ultraviolet, down to 230 nm. Occasionally, while Type IIa diamonds are being extruded towards" +
                        " the surface of the Earth, the pressure and tension can cause structural anomalies arising through plastic deformation " +
                        "during the growth of the tetrahedral crystal structure, leading to imperfections. These imperfections can confer a yellow," +
                        " brown, orange, pink, red, or purple colour to the gem. Type IIa diamonds can have their structural deformations repaired " +
                        "via a high-pressure high-temperature (HPHT) process, removing much or all of the diamond's color.[6] Type IIa diamonds constitute" +
                        " a great percentage of Australian production. Many famous large diamonds, like the Cullinan, Koh-i-Noor, and Lesedi La Rona, are Type IIa. " +
                        "Synthetic diamonds grown using the CVD process typically also belong to this type."
                    , ProductCategoryId = 21},
                    new Brilliant { Id = 19, name = "Type IIb", 
                        description = "Type IIb diamonds make up about 0.1% of all natural diamonds, making them one of the rarest natural diamonds and very valuable." +
                        " In addition to having very low levels of nitrogen impurities comparable to Type IIa diamonds, Type IIb diamonds contain significant boron impurities." +
                        " The absorption spectrum of boron causes these gems to absorb red, orange, and yellow light, lending Type IIb diamonds a light blue or grey color," +
                        " though examples with low levels of boron impurities can also be colorless."
                    , },
                }

                );

            modelBuilder.Entity<ProductCategory>().HasData(
                
                new ProductCategory[]
                { 
                    new ProductCategory { Id = 20, Name = "Metal" },
                    new ProductCategory { Id = 21, Name = "Stones" },
                
                }

               

                );



        }

        public void CreateIfNotExist()
        {
            Database.EnsureCreated();

        }
    }
}
