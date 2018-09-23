using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class CoreStateOrProvince
    {
        public CoreStateOrProvince()
        {
            CoreDistrict = new HashSet<CoreDistrict>();
        }

        public long Id { get; set; }
        public string CountryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public CoreCountry Country { get; set; }
        public ICollection<CoreDistrict> CoreDistrict { get; set; }
    }
}
