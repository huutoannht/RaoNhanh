﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCore.Models.EntitiesFramework;

namespace NetCore.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20180923081722_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("Description");

                    b.Property<int>("DisplayOrder");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Picture")
                        .HasMaxLength(256);

                    b.Property<bool>("ShowOnHomePage");

                    b.Property<string>("SiteId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("UpdatedOnUtc")
                        .HasColumnType("datetime");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Communicate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<string>("Message")
                        .HasMaxLength(2000);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("Phone")
                        .HasMaxLength(11);

                    b.Property<string>("SiteId")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Communicate");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(256);

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("Facebook")
                        .HasMaxLength(256);

                    b.Property<string>("Instagram")
                        .HasMaxLength(256);

                    b.Property<string>("Latitude")
                        .HasMaxLength(50);

                    b.Property<string>("Logo")
                        .HasMaxLength(256);

                    b.Property<string>("Longitude")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NameWebsite")
                        .HasMaxLength(256);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("SiteId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("TimeWorking")
                        .HasMaxLength(256);

                    b.Property<string>("Twitter")
                        .HasMaxLength(256);

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.CoreCountry", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Code3");

                    b.Property<bool>("IsBillingEnabled");

                    b.Property<bool>("IsCityEnabled");

                    b.Property<bool>("IsDistrictEnabled");

                    b.Property<bool>("IsShippingEnabled");

                    b.Property<bool>("IsZipCodeEnabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.ToTable("Core_Country");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.CoreDistrict", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<long>("StateOrProvinceId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Core_District");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.CoreStateOrProvince", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("CountryId")
                        .HasMaxLength(450);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Core_StateOrProvince");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.ItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("NameItemCategory")
                        .HasMaxLength(256);

                    b.Property<string>("UserCreated")
                        .HasMaxLength(256);

                    b.Property<string>("UserModifed")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("ItemCategory");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("ImageAlias")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("ImageName")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("ImageUrlSmall")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ProductId");

                    b.Property<string>("ShortDecription")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("SiteId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("TypePicture");

                    b.Property<DateTime>("UpdatedOnUtc")
                        .HasColumnType("datetime");

                    b.HasKey("PictureId");

                    b.HasIndex("ProductId");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.PostingCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<string>("NamePostingCategory")
                        .HasMaxLength(256);

                    b.Property<string>("UserCreated")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("PostingCategory");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnName("AddressID");

                    b.Property<double?>("Area");

                    b.Property<int?>("CapacityPeople");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("FullDescription");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("NameCompany")
                        .HasMaxLength(256);

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11);

                    b.Property<string>("Picture")
                        .HasMaxLength(400);

                    b.Property<string>("PictureSmall")
                        .HasMaxLength(400);

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<string>("ProductAlias")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("Recruiter")
                        .HasMaxLength(256);

                    b.Property<int?>("See");

                    b.Property<string>("ShortDescription");

                    b.Property<bool>("ShowOnHomePage");

                    b.Property<string>("SiteId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("UpdatedOnUtc")
                        .HasColumnType("datetime");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetRoleClaims", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserClaims", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserLogins", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserRoles", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NetCore.Models.EntitiesFramework.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.AspNetUserTokens", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.CoreDistrict", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.CoreStateOrProvince", "StateOrProvince")
                        .WithMany("CoreDistrict")
                        .HasForeignKey("StateOrProvinceId");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.CoreStateOrProvince", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.CoreCountry", "Country")
                        .WithMany("CoreStateOrProvince")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Picture", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.Product", "Product")
                        .WithMany("PictureNavigation")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Picture_Product");
                });

            modelBuilder.Entity("NetCore.Models.EntitiesFramework.Product", b =>
                {
                    b.HasOne("NetCore.Models.EntitiesFramework.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Product_Category");
                });
#pragma warning restore 612, 618
        }
    }
}
