using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class ItemCategory
    {
        public ItemCategory()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string NameItemCategory { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public string UserCreated { get; set; }
        public string UserModifed { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
