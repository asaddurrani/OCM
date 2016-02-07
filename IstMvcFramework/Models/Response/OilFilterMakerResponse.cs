using System.Collections.Generic;

namespace IstMvcFramework.Models.Response
{
    public class OilFilterMakerResponse
    {
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.OilFilterMakerCompany> OilFilterMakerCompanies { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}