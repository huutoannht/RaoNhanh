using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string SiteId { get; set; }
        public string Address { get; set; }
        public string TimeWorking { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Logo { get; set; }
        public string NameWebsite { get; set; }
    }
}
