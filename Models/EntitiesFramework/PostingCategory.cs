using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class PostingCategory
    {
        public PostingCategory()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string NamePostingCategory { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public string UserCreated { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
