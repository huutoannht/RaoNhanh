using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class PostingCategory
    {
        public int Id { get; set; }
        public string NamePostingCategory { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public string UserCreated { get; set; }
    }
}
