using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class CoreDistrict
    {
        public long Id { get; set; }
        public long StateOrProvinceId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }

        public CoreStateOrProvince StateOrProvince { get; set; }
    }
}
