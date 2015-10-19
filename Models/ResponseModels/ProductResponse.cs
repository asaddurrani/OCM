using System.Collections.Generic;
using Models.DomainModels;

namespace Models.ResponseModels
{
    /// <summary>
    /// Product Response
    /// </summary>
    public sealed class ProductResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ProductResponse()
        {
            Products = new List<Models.DomainModels.Product>();
        }

        /// <summary>
        /// Products
        /// </summary>
        public IEnumerable<Models.DomainModels.Product> Products { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
