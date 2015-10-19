﻿using System;
using System.Collections.Generic;
using System.Linq;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IProductRepository : IBaseRepository<Product, int>
    {
        ProductResponse GetAllProducts(ProductSearchRequest productSearchRequest);
        IQueryable<Product> GetProductsByCategory(int catID);
        Product GetProductByName(string name, int id);
    }
}
