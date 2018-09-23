using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class Picture
    {
        public int PictureId { get; set; }
        public int? ProductId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public string ImageAlias { get; set; }
        public bool IsDeleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int TypePicture { get; set; }
        public string Description { get; set; }
        public string ShortDecription { get; set; }
        public string ImageUrlSmall { get; set; }

        public Product Product { get; set; }
    }
}
