using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class Category
    {
        public Category()
        {
            ItemCategory = new HashSet<ItemCategory>();
            PostingCategory = new HashSet<PostingCategory>();
            Product = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string KeyValue { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public bool IsDeleted { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string Picture { get; set; }

        public ICollection<ItemCategory> ItemCategory { get; set; }
        public ICollection<PostingCategory> PostingCategory { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
