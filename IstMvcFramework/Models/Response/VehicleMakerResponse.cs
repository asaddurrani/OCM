using System.Collections.Generic;

namespace IstMvcFramework.Models.Response
{
    public sealed class VehicleMakerResponse
    {
        /// <summary>
        /// Vehicle Makers
        /// </summary>
        public IEnumerable<Models.VehicleMaker> VehicleMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}