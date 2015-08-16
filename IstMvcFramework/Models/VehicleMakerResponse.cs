using System.Collections.Generic;

namespace IstMvcFramework.Models
{
    public sealed class VehicleMakerResponse
    {
        /// <summary>
        /// Products
        /// </summary>
        public IEnumerable<Models.VehicleMaker> VehicleMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}