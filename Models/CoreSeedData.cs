using System;
using Microsoft.EntityFrameworkCore;
using NetCore.Models.EntitiesFramework;

namespace NetCore.Models
{
    public static class CoreSeedData
    {
        public static void SeedData(ModelBuilder builder)
        {
            builder.Entity<AspNetRoles>().HasData(
            );

            builder.Entity<AspNetUsers>().HasData(
            );

        }
    }
}
