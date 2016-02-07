using System.Collections.Generic;

namespace IstMvcFramework.Models.Response
{
    public class AirFilterResponse
    {
        /// <summary>
        /// Air Filters
        /// </summary>
        public IEnumerable<Models.AirFilter> AirFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}