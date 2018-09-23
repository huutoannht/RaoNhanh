using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class Product
    {
        public Product()
        {
            PictureNavigation = new HashSet<Picture>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public decimal? Price { get; set; }
        public decimal? OldPrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string SiteId { get; set; }
        public string Picture { get; set; }
        public string ProductAlias { get; set; }
        public int? See { get; set; }
        public string PictureSmall { get; set; }
        public string NameCompany { get; set; }
        public int? AddressId { get; set; }
        public int? CapacityPeople { get; set; }
        public string PhoneNumber { get; set; }
        public string Recruiter { get; set; }
        public double? Area { get; set; }

        public Category Category { get; set; }
        public ICollection<Picture> PictureNavigation { get; set; }
    }
}
