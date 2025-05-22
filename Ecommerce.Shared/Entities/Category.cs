using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<ProductCategory>? ProdCategories { get; set; }
    }
}
