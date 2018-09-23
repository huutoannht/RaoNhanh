using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Models
{
    public class CoreCustomModelBuilder 
    {
        public void Build(ModelBuilder modelBuilder)
        {
            CoreSeedData.SeedData(modelBuilder);
        }
    }
}
