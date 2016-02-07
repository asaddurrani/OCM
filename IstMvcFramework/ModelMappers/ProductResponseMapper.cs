using System.Linq;
using IstMvcFramework.Models.Response;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    /// <summary>
    /// Product Response Mapper
    /// </summary>
    public static class ProductResponseMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static ProductResponse CreateFrom(this MainDomain.ProductResponse source)
        {
            return new ProductResponse
            {
                TotalCount = source.TotalCount,
                Products = source.Products.Select(p => p.CreateFrom())
            };
           
        }

        #endregion

    }
}
