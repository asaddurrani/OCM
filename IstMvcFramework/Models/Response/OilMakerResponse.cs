using System.Collections.Generic;

namespace IstMvcFramework.Models.Response
{
    public sealed class OilMakerResponse
    {
        /// <summary>
        /// Oil Makers
        /// </summary>
        public IEnumerable<Models.OilMakerCompany> OilMakerCompanies { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}