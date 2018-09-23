using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCore.Models
{
    public class PictureDTO
    {
        public int PictureId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public string ImageAlias { get; set; }
        public bool IsDeleted { get; set; }
        public int DisplayOrder { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
        public System.DateTime UpdatedOnUtc { get; set; }
        public Nullable<int> SiteId { get; set; }
        public Nullable<int> ProductId { get; set; }

    }
}