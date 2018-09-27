using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace NetCore.Models.EntitiesFramework
{
    public partial class ProductContext
    {
        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                      .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.UtcNow;
                    entry.Property("CreatedBy").CurrentValue = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("ModifiedDate").CurrentValue = DateTime.UtcNow;
                    entry.Property("ModifiedBy").CurrentValue = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }

}
