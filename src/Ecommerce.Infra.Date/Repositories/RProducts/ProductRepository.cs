using Ecommerce.Domain.Interfaces.IProducts;
using Ecommerce.Entity.Entities.Products;
using Ecommerce.Infra.Date.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infra.Date.Repositories.RProducts
{
    public class ProductRepository : GenericRepository<Product>, IProduct
    {
    }
}
