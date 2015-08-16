using System.Collections.Generic;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IProductService
    {
        ProductResponse LoadAllProducts(ProductSearchRequest productSearchRequest);
        Products FindProduct(int id);
        IEnumerable<Products> FindProductsByCategory(int catId); 
        void DeleteProduct(Products product);
        bool AddProduct(Products product);
        bool Update(Products product);//,Category category

    }
}
