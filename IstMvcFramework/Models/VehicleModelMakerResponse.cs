using System.Collections.Generic;

namespace IstMvcFramework.Models
{
    public sealed class VehicleModelMakerResponse
    {
        /// <summary>
        /// Vehicle Model Makers
        /// </summary>
        public IEnumerable<Models.VehicleModelMaker> VehicleModelMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}