using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    SiteId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ShowOnHomePage = table.Column<bool>(nullable: false),
                    Picture = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Communicate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteId = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    Message = table.Column<string>(maxLength: 2000, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communicate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 256, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Longitude = table.Column<string>(maxLength: 50, nullable: true),
                    Latitude = table.Column<string>(maxLength: 50, nullable: true),
                    SiteId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    TimeWorking = table.Column<string>(maxLength: 256, nullable: true),
                    Facebook = table.Column<string>(maxLength: 256, nullable: true),
                    Instagram = table.Column<string>(maxLength: 256, nullable: true),
                    Twitter = table.Column<string>(maxLength: 256, nullable: true),
                    Logo = table.Column<string>(maxLength: 256, nullable: true),
                    NameWebsite = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Core_Country",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
                    Code3 = table.Column<string>(nullable: true),
                    IsBillingEnabled = table.Column<bool>(nullable: false),
                    IsShippingEnabled = table.Column<bool>(nullable: false),
                    IsCityEnabled = table.Column<bool>(nullable: false),
                    IsZipCodeEnabled = table.Column<bool>(nullable: false),
                    IsDistrictEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameItemCategory = table.Column<string>(maxLength: 256, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserCreated = table.Column<string>(maxLength: 256, nullable: true),
                    UserModifed = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostingCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamePostingCategory = table.Column<string>(maxLength: 256, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserCreated = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostingCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    FullDescription = table.Column<string>(nullable: true),
                    ShowOnHomePage = table.Column<bool>(nullable: false),
                    MetaKeywords = table.Column<string>(maxLength: 400, nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    OldPrice = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    DisplayOrder = table.Column<int>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    SiteId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Picture = table.Column<string>(maxLength: 400, nullable: true),
                    ProductAlias = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    See = table.Column<int>(nullable: true),
                    PictureSmall = table.Column<string>(maxLength: 400, nullable: true),
                    NameCompany = table.Column<string>(maxLength: 256, nullable: true),
                    AddressID = table.Column<int>(nullable: true),
                    CapacityPeople = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: true),
                    Recruiter = table.Column<string>(maxLength: 256, nullable: true),
                    Area = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_StateOrProvince",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<string>(maxLength: 450, nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_StateOrProvince", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_StateOrProvince_Core_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Core_Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    PictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(unicode: false, maxLength: 256, nullable: true),
                    ImageName = table.Column<string>(maxLength: 500, nullable: true),
                    ImageAlias = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    SiteId = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TypePicture = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    ShortDecription = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    ImageUrlSmall = table.Column<string>(unicode: false, maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.PictureId);
                    table.ForeignKey(
                        name: "FK_Picture_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_District",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateOrProvinceId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_District_Core_StateOrProvince_StateOrProvinceId",
                        column: x => x.StateOrProvinceId,
                        principalTable: "Core_StateOrProvince",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_District_StateOrProvinceId",
                table: "Core_District",
                column: "StateOrProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_StateOrProvince_CountryId",
                table: "Core_StateOrProvince",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_ProductId",
                table: "Picture",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Communicate");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Core_District");

            migrationBuilder.DropTable(
                name: "ItemCategory");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "PostingCategory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Core_StateOrProvince");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Core_Country");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
