using Microsoft.EntityFrameworkCore;

namespace NetCore.Models.EntitiesFramework
{
    public partial class ProductContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
          : base(options)
        {
        }
    }
}
