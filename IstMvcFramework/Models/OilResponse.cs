using System.Collections.Generic;

namespace IstMvcFramework.Models
{
    public class OilResponse
    {
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.Oil> Oils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}