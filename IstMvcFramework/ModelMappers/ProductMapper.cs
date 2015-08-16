using IstMvcFramework.Resources.Products;
using MainDomain = Models.DomainModels;

namespace IstMvcFramework.ModelMappers
{
    public static class ProductMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.Product CreateFrom(this MainDomain.Products source)
        {
             return new Models.Product
            {
                Id = source.Id,
                Name = source.Name,
                CategoryId = source.CategoryId,
                Description = source.Description,
                Price = source.Price,
                Category=source.Category.CreateFrom()
            };
           
        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.Products CreateFrom(this Models.Product source)
        {
             return new MainDomain.Products
            {
                Id = source.Id,
                Name = source.Name,
                CategoryId = source.CategoryId,
                Description = source.Description,
                Price = source.Price
            };
           
        }

        #endregion

    }
}
