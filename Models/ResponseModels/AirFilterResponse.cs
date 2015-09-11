using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class AirFilterResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AirFilterResponse()
        {
            AirFilters = new List<DomainModels.AirFilter>();
        }

        /// <summary>
        /// Air Filters
        /// </summary>
        public IEnumerable<DomainModels.AirFilter> AirFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
