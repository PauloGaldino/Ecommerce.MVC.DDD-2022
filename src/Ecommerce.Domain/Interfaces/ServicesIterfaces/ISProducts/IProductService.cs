using Ecommerce.Entity.Entities.Products;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces.ServicesIterfaces.ISProducts
{
    public interface IProductService
    {
        //============Métodos custumizados=======

        Task AddProduct(Product product);

        Task UpdateProduct(Product product);
    }
}