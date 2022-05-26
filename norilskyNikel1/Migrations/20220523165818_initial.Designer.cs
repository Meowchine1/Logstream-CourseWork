﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using norilskyNikel1.EF;

#nullable disable

namespace norilskyNikel1.Migrations
{
    [DbContext(typeof(NornikelContext))]
    [Migration("20220523165818_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("norilskyNikel1.EF.Brilliant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("brilliants");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            ProductCategoryId = 21,
                            description = "Type Ia diamonds make up about 95% of all natural diamonds. The nitrogen impurities, up to 0.3% (3000 ppm), are clustered within the carbon lattice, and are relatively widespread. The absorption spectrum of the nitrogen clusters can cause the diamond to absorb blue light, making it appear pale yellow or almost colorless. Most Ia diamonds are a mixture of IaA and IaB material; these diamonds belong to the Cape series, named after the diamond-rich region formerly known as Cape Province in South Africa, whose deposits are largely Type Ia.",
                            name = "Type Ia"
                        },
                        new
                        {
                            Id = 17,
                            ProductCategoryId = 21,
                            description = "Type Ib make up about 0.1% of all natural diamonds. They contain up to 0.05% (500 ppm) of nitrogen, but the impurities are more diffuse, the atoms are dispersed throughout the crystal in isolated sites. Type Ib diamonds absorb green light in addition to blue, and have a more intense or darker yellow or brown colour than Type Ia diamonds. The stones have an intense yellow or occasionally brown tint; the rare canary diamonds belong to this type, which represents only 0.1% of known natural diamonds. The visible absorption spectrum is gradual, without sharp absorption bands.[4] Almost all HPHT synthetic diamonds are of Type Ib.",
                            name = "Type IB"
                        },
                        new
                        {
                            Id = 18,
                            ProductCategoryId = 21,
                            description = "Type IIa diamonds make up 1–2% of all natural diamonds (1.8% of gem diamonds). These diamonds are almost or entirely devoid of impurities, and consequently are usually colourless and have the highest thermal conductivity. They are very transparent in ultraviolet, down to 230 nm. Occasionally, while Type IIa diamonds are being extruded towards the surface of the Earth, the pressure and tension can cause structural anomalies arising through plastic deformation during the growth of the tetrahedral crystal structure, leading to imperfections. These imperfections can confer a yellow, brown, orange, pink, red, or purple colour to the gem. Type IIa diamonds can have their structural deformations repaired via a high-pressure high-temperature (HPHT) process, removing much or all of the diamond's color.[6] Type IIa diamonds constitute a great percentage of Australian production. Many famous large diamonds, like the Cullinan, Koh-i-Noor, and Lesedi La Rona, are Type IIa. Synthetic diamonds grown using the CVD process typically also belong to this type.",
                            name = "Type IIa"
                        },
                        new
                        {
                            Id = 19,
                            ProductCategoryId = 0,
                            description = "Type IIb diamonds make up about 0.1% of all natural diamonds, making them one of the rarest natural diamonds and very valuable. In addition to having very low levels of nitrogen impurities comparable to Type IIa diamonds, Type IIb diamonds contain significant boron impurities. The absorption spectrum of boron causes these gems to absorb red, orange, and yellow light, lending Type IIb diamonds a light blue or grey color, though examples with low levels of boron impurities can also be colorless.",
                            name = "Type IIb"
                        });
                });

            modelBuilder.Entity("norilskyNikel1.EF.Metal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("metal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductCategoryId = 20,
                            description = "Palladium is a chemical element with the symbol Pd and atomic number 46. It is a rare and lustrous silvery-white metal discovered in 1803 by the English chemist William Hyde Wollaston. He named it after the asteroid Pallas, which was itself named after the epithet of the Greek goddess Athena, acquired by her when she slew Pallas. Palladium, platinum, rhodium, ruthenium, iridium and osmium form a group of elements referred to as the platinum group metals (PGMs). They have similar chemical properties, but palladium has the lowest melting point and is the least dense of them.",
                            name = "Yrilski Palalladiy"
                        },
                        new
                        {
                            Id = 12,
                            ProductCategoryId = 20,
                            description = "Gold is a chemical element with the symbol Au (from Latin: aurum) and atomic number 79, making it one of the higher atomic number elements that occur naturally. It is a bright, slightly orange-yellow, dense, soft, malleable, and ductile metal in a pure form. Chemically, gold is a transition metal and a group 11 element. It is one of the least reactive chemical elements and is solid under standard conditions. Gold often occurs in free elemental (native) form, as nuggets or grains, in rocks, veins, and alluvial deposits.",
                            name = "Russian gold"
                        },
                        new
                        {
                            Id = 13,
                            ProductCategoryId = 0,
                            description = "Silver is a chemical element with the symbol Ag (from the Latin argentum, derived from the Proto-Indo-European h₂erǵ: shiny or white) and atomic number 47. A soft, white, lustrous transition metal, it exhibits the highest electrical conductivity, thermal conductivity, and reflectivity of any metal.[4] The metal is found in the Earth's crust in the pure, free elemental form (native silver), as an alloy with gold and other metals, and in minerals such as argentite and chlorargyrite. ",
                            name = "Silver"
                        },
                        new
                        {
                            Id = 14,
                            ProductCategoryId = 20,
                            description = "Copper is a chemical element with the symbol Cu (from Latin: cuprum) and atomic number 29. It is a soft, malleable, and ductile metal with very high thermal and electrical conductivity. A freshly exposed surface of pure copper has a pinkish-orange color. Copper is used as a conductor of heat and electricity, as a building material, and as a constituent of various metal alloys, such as sterling silver used in jewelry, cupronickel used to make marine hardware and coins, and constantan used in strain gauges and thermocouples for temperature measurement.",
                            name = "Copper"
                        },
                        new
                        {
                            Id = 25,
                            ProductCategoryId = 20,
                            description = "Cobalt is a chemical element with the symbol Co and atomic number 27. As with nickel, cobalt is found in the Earth's crust only in a chemically combined form, save for small deposits found in alloys of natural meteoric iron. The free element, produced by reductive smelting, is a hard, lustrous, silver-gray metal.",
                            name = "Cobalt"
                        });
                });

            modelBuilder.Entity("norilskyNikel1.EF.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("productCategories");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Name = "Metal"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Stones"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
