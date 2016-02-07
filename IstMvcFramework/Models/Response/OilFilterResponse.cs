using System.Collections.Generic;

namespace IstMvcFramework.Models.Response
{
    public class OilFilterResponse
    {
        /// <summary>
        /// Oil Filters
        /// </summary>
        public IEnumerable<Models.OilFilter> OilFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}