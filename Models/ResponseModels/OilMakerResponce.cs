using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class OilMakerResponce
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OilMakerResponce()
        {
            OilMakers = new List<DomainModels.OilMakerCompany>();
        }

        /// <summary>
        /// Products
        /// </summary>
        public IEnumerable<DomainModels.OilMakerCompany> OilMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
