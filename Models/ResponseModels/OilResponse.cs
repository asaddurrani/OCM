using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class OilResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OilResponse()
        {
            Oils = new List<DomainModels.Oil>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<DomainModels.Oil> Oils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
