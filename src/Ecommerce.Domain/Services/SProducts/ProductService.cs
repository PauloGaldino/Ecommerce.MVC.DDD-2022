using Ecommerce.Domain.Interfaces.IProducts;
using Ecommerce.Domain.Interfaces.ServicesIterfaces.ISProducts;
using Ecommerce.Entity.Entities.Products;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services.SProducts
{
    /// <summary>
    /// Esta classe fica responsável
    /// por manter as regras de negócio
    /// e as validaçõesda entidade 
    /// de produto
    /// </summary>
    public class ProductService : IProductService
    {
        //Injeção de dependencia
        private readonly IProduct _IProduct;

        //Construtor
        public ProductService(IProduct IProduct)
        {
            _IProduct = IProduct;
        }


        //Métodos 
        public async Task AddProduct(Product product)
        {
            var validateName = product.ValidateStringProperty(product.Name, "Name");
            var validateValue = product.ValidateDecimalProperty(product.Value, "Value");

            if (validateName && validateValue)
            {
                product.State = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validateName = product.ValidateStringProperty(product.Name, "Name");
            var validateValue = product.ValidateDecimalProperty(product.Value, "Value");

            if (validateName && validateValue)
            {
                await _IProduct.UpDate(product);
            }
        }
    }
}
