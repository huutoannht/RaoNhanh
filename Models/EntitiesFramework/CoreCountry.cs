using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class CoreCountry
    {
        public CoreCountry()
        {
            CoreStateOrProvince = new HashSet<CoreStateOrProvince>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Code3 { get; set; }
        public bool IsBillingEnabled { get; set; }
        public bool IsShippingEnabled { get; set; }
        public bool IsCityEnabled { get; set; }
        public bool IsZipCodeEnabled { get; set; }
        public bool IsDistrictEnabled { get; set; }

        public ICollection<CoreStateOrProvince> CoreStateOrProvince { get; set; }
    }
}
