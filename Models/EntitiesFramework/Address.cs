using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class Address
    {
        public Address()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CountryId { get; set; }
        public int? ProviceId { get; set; }
        public int? DistrictId { get; set; }
        public string NameAddress { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
