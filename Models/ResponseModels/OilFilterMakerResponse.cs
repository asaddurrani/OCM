using System.Collections.Generic;

namespace Models.ResponseModels
{
    public class OilFilterMakerResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OilFilterMakerResponse()
        {
            OilFilterMakerCompanies = new List<DomainModels.OilFilterMakerCompany>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<DomainModels.OilFilterMakerCompany> OilFilterMakerCompanies { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
