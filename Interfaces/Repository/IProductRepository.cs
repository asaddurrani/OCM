using System;
using System.Collections.Generic;
using System.Linq;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IProductRepository : IBaseRepository<Products, int>
    {
        ProductResponse GetAllProducts(ProductSearchRequest productSearchRequest);
        IQueryable<Products> GetProductsByCategory(int catID);
        Products GetProductByName(string name, int id);
    }
}
