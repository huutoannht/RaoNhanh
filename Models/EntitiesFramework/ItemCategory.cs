using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class ItemCategory
    {
        public int Id { get; set; }
        public string NameItemCategory { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public string UserCreated { get; set; }
        public string UserModifed { get; set; }
    }
}
