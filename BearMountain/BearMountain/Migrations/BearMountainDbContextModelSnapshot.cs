﻿// <auto-generated />
using BearMountain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BearMountain.Migrations
{
    [DbContext(typeof(BearMountainDbContext))]
    partial class BearMountainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BearMountain.Models.BasketItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CheckedOut");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<int>("UserBasketID");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserBasketID");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("BearMountain.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("SKU");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 101, Description = "The Arc'teryx Atom LT Insulated hoodie featuring Coreloft™ insulation and air permeable side panels functions as an outer layer or as a mid layer depending on the conditions.", Image = "arcteryxJacket.jpg", Name = "Arc'teryx Atom LT Insulated Hoodie", Price = 259m, SKU = "137913" },
                        new { ID = 102, Description = "A lightweight, roomy design for 3-season backpacking, The North Face Furnace 20 sleeping bag is insulated with water-resistant ProDown, which repels water and dries faster than traditional down.", Image = "northFaceBag.jpg", Name = "The North Face Furnace 20 Sleeping Bag", Price = 189m, SKU = "117155" },
                        new { ID = 103, Description = "Your home away from home shouldn't skimp on the essentials. The 3-season REI Co-op Half Dome 2 Plus backpacking tent provides you and a partner with plenty of room to stretch out and stay comfortable.", Image = "reiTent.jpg", Name = "REI Co-op Half Dome 2 Plus Tent", Price = 229m, SKU = "128692" },
                        new { ID = 104, Description = "For a long week on the trail or a gear - intensive weekend where extra volume is vital, the Osprey Aether AG 70 pack enhances mobility and comfort with the Anti - Gravity harness and suspended - mesh back.", Image = "ospreyPack.jpg", Name = "Osprey Aether AG 70 Pack ", Price = 310m, SKU = "111284" },
                        new { ID = 105, Description = "Weighing in at a sleek 45 lbs., the Delta 14 Kayak with rudder from Delta Kayaks delivers speed and stability and offers tons of gear storage for weekend trips and extended tours.", Image = "deltaKayak.jpg", Name = "Delta Kayaks Delta 14 Kayak", Price = 1995m, SKU = "867763" },
                        new { ID = 106, Description = "The pinnacle of ultralight, aggressive all-terrain performance, MSR Lightning Ascent snowshoes offer tough, reliable decking for exploring mountainous winter wonderlands.", Image = "msrSnowShoes.jpg", Name = "MSR Lightning Ascent Snowshoes", Price = 299m, SKU = "120297" },
                        new { ID = 107, Description = "Looking for a capable all-rounder for days on the mountain? The GHOST Kato FS 7.7 27.5 mountain bike offers full-suspension fun on a hydroformed aluminum frame.", Image = "ghostBike.jpg", Name = "GHOST Kato FS 7.7 27.5 Bike", Price = 2029m, SKU = "125922" },
                        new { ID = 108, Description = "The Black Diamond Trail Back trekking poles offer a reliable, easily adjustable, 3-section design for daily hikes and multiday adventures.", Image = "blackMountainPoles.jpg", Name = "Black Diamond Trail Back Trekking Poles - Pair", Price = 79m, SKU = "895931" },
                        new { ID = 109, Description = "The serious capacity on this Hydro Flask Wide-Mouth 40 oz. vacuum water bottle is perfect for all-day hydration (including ice cubes) or finishing your hike with hot soup.", Image = "hydroFlask.jpg", Name = "Hydro Flask Wide-Mouth Vacuum Water Bottle - 40 fl. oz.", Price = 42m, SKU = "100106" },
                        new { ID = 110, Description = "With cushioning for the perfect amount of support and a smooth fit with no slipping, bunching, or blisters, the Darn Tough Hiker Boot Sock Cushion socks have earned a place in the hearts of hikers.", Image = "socks.jpg", Name = "Darn Tough Hiker Boot Sock Cushion Socks", Price = 24m, SKU = "887221" }
                    );
                });

            modelBuilder.Entity("BearMountain.Models.UserBasket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("UserBasket");
                });

            modelBuilder.Entity("BearMountain.Models.BasketItem", b =>
                {
                    b.HasOne("BearMountain.Models.Product", "Product")
                        .WithMany("BasketItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BearMountain.Models.UserBasket", "UserBasket")
                        .WithMany("BasketItems")
                        .HasForeignKey("UserBasketID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
