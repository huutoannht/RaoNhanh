using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCore.Models.EntitiesFramework
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Communicate> Communicate { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<CoreCountry> CoreCountry { get; set; }
        public virtual DbSet<CoreDistrict> CoreDistrict { get; set; }
        public virtual DbSet<CoreStateOrProvince> CoreStateOrProvince { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<PostingCategory> PostingCategory { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;initial catalog=Product;persist security info=True;user id=sa;password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.CountryId).HasMaxLength(450);

                entity.Property(e => e.NameAddress).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.KeyValue).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Picture).HasMaxLength(256);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Communicate>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.SiteId).HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(256);

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook).HasMaxLength(256);

                entity.Property(e => e.Instagram).HasMaxLength(256);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Logo).HasMaxLength(256);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NameWebsite).HasMaxLength(256);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeWorking).HasMaxLength(256);

                entity.Property(e => e.Twitter).HasMaxLength(256);
            });

            modelBuilder.Entity<CoreCountry>(entity =>
            {
                entity.ToTable("Core_Country");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<CoreDistrict>(entity =>
            {
                entity.ToTable("Core_District");

                entity.HasIndex(e => e.StateOrProvinceId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.StateOrProvince)
                    .WithMany(p => p.CoreDistrict)
                    .HasForeignKey(d => d.StateOrProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CoreStateOrProvince>(entity =>
            {
                entity.ToTable("Core_StateOrProvince");

                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CoreStateOrProvince)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.NameItemCategory).HasMaxLength(256);

                entity.Property(e => e.UserCreated).HasMaxLength(256);

                entity.Property(e => e.UserModifed).HasMaxLength(256);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ItemCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ItemCategory_Category");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ImageAlias)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName).HasMaxLength(500);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrlSmall)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDecription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PictureNavigation)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Picture_Product");
            });

            modelBuilder.Entity<PostingCategory>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.NamePostingCategory).HasMaxLength(256);

                entity.Property(e => e.UserCreated).HasMaxLength(256);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PostingCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PostingCategory_Category");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.NameCompany).HasMaxLength(256);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.Picture).HasMaxLength(400);

                entity.Property(e => e.PictureSmall).HasMaxLength(400);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductAlias)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Recruiter).HasMaxLength(256);

                entity.Property(e => e.Seller).HasMaxLength(256);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Product_Address");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("FK_Product_ItemCategory");

                entity.HasOne(d => d.PostingCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.PostingCategoryId)
                    .HasConstraintName("FK_Product_PostingCategory");
            });
        }
    }
}
