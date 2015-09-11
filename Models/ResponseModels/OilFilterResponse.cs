using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class OilFilterResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OilFilterResponse()
        {
            OilFilters = new List<DomainModels.OilFilter>();
        }

        /// <summary>
        /// Oil Filters
        /// </summary>
        public IEnumerable<DomainModels.OilFilter> OilFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
