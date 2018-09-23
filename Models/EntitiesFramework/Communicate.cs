using System;
using System.Collections.Generic;

namespace NetCore.Models.EntitiesFramework
{
    public partial class Communicate
    {
        public int Id { get; set; }
        public string SiteId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
