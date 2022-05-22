using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Store.Models
{
    public class StoreContext : IdentityDbContext<User, Role, int>
    {

        public virtual DbSet<Gender> Genders { get; set; }
        public override DbSet<User> Users { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }





        public StoreContext()
        {

        }

        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
            
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);




            //zmiana nazw tabel z domyślnych na ładniejsze
            modelBuilder.Entity<User>(i =>
            {
                RelationalEntityTypeBuilderExtensions.ToTable((EntityTypeBuilder)i, "Users");
                i.HasKey(x => x.Id);
            });
            modelBuilder.Entity<Role>(i =>
            {
                RelationalEntityTypeBuilderExtensions.ToTable((EntityTypeBuilder)i, "Role");
                i.HasKey(x => x.Id);
            });
            modelBuilder.Entity<IdentityUserRole<int>>(i =>
            {
                i.ToTable("UserRole");
                i.HasKey(x => new { x.RoleId, x.UserId });
            });
            modelBuilder.Entity<IdentityUserLogin<int>>(i =>
            {
                i.ToTable("UserLogin");
                i.HasKey(x => new { x.ProviderKey, x.LoginProvider });
            });
            modelBuilder.Entity<IdentityRoleClaim<int>>(i =>
            {
                i.ToTable("RoleClaims");
                i.HasKey(x => x.Id);
            });
            modelBuilder.Entity<IdentityUserClaim<int>>(i =>
            {
                i.ToTable("UserClaims");
                i.HasKey(x => x.Id);
            });


            modelBuilder.Entity<Product>(c =>
            {
                c.Property(p => p.Id)
                    .ValueGeneratedOnAdd();
            });

            //modelBuilder.Entity<User>()
            //.HasMany(c => c.Orders)
            //.WithOne(e => e.User)
            //.HasForeignKey(s => s.UserId);



            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.StockId, x.OrderId });


            //Dodanie płci do tabeli Gender
            modelBuilder.Entity<Gender>()
                .HasData(
                    new Gender
                    {
                        Id = 1,
                        Name = "Мужчина"
                    },
                    new Gender
                    {
                        Id = 2,
                        Name = "Женщина"
                    },
                    new Gender
                    {
                        Id = 3,
                        Name = "Неизвестное"
                    }
                );



            //Dodanie roli do tabeli Role
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "User",
                        NormalizedName = "USER"
                    }
                );

           


            //Dodanie płci do tabeli Sex
            modelBuilder.Entity<Sex>()
                .HasData(
                    new Gender
                    {
                        Id = 1,
                        Name = "Мужчина"
                    },
                    new Gender
                    {
                        Id = 2,
                        Name = "Женщина"
                    },
                    new Gender
                    {
                        Id = 3,
                        Name = "Неизвестное"
                    }
                );

            //Dodanie typów do tabeli Type
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Обувь"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Одежда"
                    }
                );


            //Dodanie marek do tabeli Brand
            modelBuilder.Entity<Brand>()
                .HasData(
                    new Brand
                    {
                        Id = 1,
                        Name = "Jordan",
                        PhotoPath = "jordan.png"
                    },
                    new Brand
                    {
                        Id = 2,
                        Name = "Adidas",
                        PhotoPath = "adidas.png"
                    },
                    new Brand
                    {
                        Id = 3,
                        Name = "Nike",
                        PhotoPath = "nike.png"
                    },
                    new Brand
                    {
                        Id = 4,
                        Name = "Supreme",
                        PhotoPath = "supreme.png"
                    }
                );

            //Dodanie kolorów do tabeli Color
            modelBuilder.Entity<Color>()
                .HasData(
                    new Color
                    {
                        Id = 1,
                        Name = "Белый"
                    },
                    new Color
                    {
                        Id = 2,
                        Name = "Черный"
                    },
                    new Color
                    {
                        Id = 3,
                        Name = "Синий"
                    },
                    new Color
                    {
                        Id = 4,
                        Name = "Желтый"
                    },
                    new Color
                    {
                        Id = 5,
                        Name = "Серый"
                    },
                    new Color
                    {
                        Id = 7,
                        Name = "Другой"
                    },
                    new Color
                    {
                        Id = 6,
                        Name = "Красный"
                    }
                );


            // Dodanie przykładowych produktów do tabeli Products
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        BrandId = 3,
                        ColorId = 2,
                        SexId = 3,
                        CategoryId = 1,
                        Name = "Air Max 97",
                        Price = 399.99m,
                        Description = "Обувь 97-го года!",
                        PhotoPath = "nikeairmax97.png"
                    },
                    new Product
                    {
                        Id = 2,
                        BrandId = 3,
                        ColorId = 1,
                        SexId = 1,
                        CategoryId = 1,
                        Name = "Cortez",
                        Price = 199.99m,
                        Description = "Классика, которую носит Форрест Гамп!",
                        PhotoPath = "nikecortez.png"
                    },
                    new Product
                    {
                        Id = 3,
                        BrandId = 1,
                        ColorId = 6,
                        SexId = 2,
                        CategoryId = 1,
                        Name = "30",
                        Price = 599.99m,
                        Description = "Еще одна модель обуви от лучшего баскетболиста!",
                        PhotoPath = "jordan30.png"
                    },
                    new Product
                    {
                        Id = 4,
                        BrandId = 4,
                        ColorId = 6,
                        SexId = 1,
                        CategoryId = 2,
                        Name = "Bogo Red",
                        Price = 999.99m,
                        Description = "Самая популярная модель толстовки Supreme!",
                        PhotoPath = "bogored.png"
                    },
                    new Product
                    {
                        Id = 5,
                        BrandId = 4,
                        ColorId = 1,
                        SexId = 1,
                        CategoryId = 2,
                        Name = "Buju Banton Tee",
                        Price = 599.99m,
                        Description = "Отличная футболка от Supreme!",
                        PhotoPath = "bujubanton.png"
                    },
                    new Product
                    {
                        Id = 6,
                        BrandId = 4,
                        ColorId = 1,
                        SexId = 3,
                        CategoryId = 2,
                        Name = "Camp Cap",
                        Price = 199.99m,
                        Description = "Черная кепка от Supreme!",
                        PhotoPath = "supremecapblack.png"
                    },
                    new Product
                    {
                        Id = 7,
                        BrandId = 2,
                        ColorId = 1,
                        SexId = 2,
                        CategoryId = 1,
                        Name = "Neo White",
                        Price = 299.99m,
                        Description = "Белые кроссовки от Adidas!",
                        PhotoPath = "adidasneowhite.png"
                    }

                );

            //Dodanie marek do tabeli Brand
            modelBuilder.Entity<Stock>()
                .HasData(
                    new Stock
                    {
                        ProductId = 1,
                        Id = 1,
                        IsLastElementOrdered = false,
                        Name = "10",
                        Qty = 3
                    },
                    new Stock
                    {
                        ProductId = 1,
                        Id = 2,
                        IsLastElementOrdered = false,
                        Name = "11",
                        Qty = 2
                    },
                    new Stock
                    {
                        ProductId = 1,
                        Id = 3,
                        IsLastElementOrdered = false,
                        Name = "12",
                        Qty = 1
                    },
                    new Stock
                    {
                        ProductId = 4,
                        Id = 4,
                        IsLastElementOrdered = false,
                        Name = "S",
                        Qty = 2
                    },
                    new Stock
                    {
                        ProductId = 4,
                        Id = 5,
                        IsLastElementOrdered = false,
                        Name = "L",
                        Qty = 2
                    },
                    new Stock
                    {
                        ProductId = 4,
                        Id = 6,
                        IsLastElementOrdered = false,
                        Name = "XL",
                        Qty = 1
                    },
                     new Stock
                     {
                         ProductId = 7,
                         Id = 7,
                         IsLastElementOrdered = false,
                         Name = "9",
                         Qty = 1
                     },
                     new Stock
                     {
                         ProductId = 2,
                         Id = 8,
                         IsLastElementOrdered = false,
                         Name = "11",
                         Qty = 3
                     }
                );


            User adminUser = new User
            {
                UserName = "admin",
                Email = "admin@store.com",
                NormalizedEmail = "admin@store.com".ToUpper(),
                NormalizedUserName = "admin".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false,
                City = "admin",
                FirstName = "admin",
                LastName = "admin",
                GenderId = 3,
                Address1 = "admin",
                PostCode = "51-627",
                Id=1,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            User user = new User
            {
                UserName = "user",
                Email = "user@store.com",
                NormalizedEmail = "user@store.com".ToUpper(),
                NormalizedUserName = "user".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "987654321",
                PhoneNumberConfirmed = false,
                City = "user",
                FirstName = "user",
                LastName = "user",
                GenderId = 1,
                Address1 = "user",
                PostCode = "51-627",
                Id=2,
                SecurityStamp = Guid.NewGuid().ToString()
            };


            PasswordHasher<User> ph = new PasswordHasher<User>();

            adminUser.PasswordHash = ph.HashPassword(adminUser, "admin");
            user.PasswordHash = ph.HashPassword(user, "user");

            var adminrole = new IdentityUserRole<int>
            { RoleId = 1, UserId = 1 };
            var userrole = new IdentityUserRole<int>
            { RoleId = 2, UserId = 2 };

            modelBuilder.Entity<User>().HasData(
                adminUser,
                user
            );

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                adminrole,
                userrole
            );
        }
    }
}
