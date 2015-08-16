using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class VehicalMakerResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VehicalMakerResponse()
        {
            VehicleMakers = new List<DomainModels.VehicleMaker>();
        }

        /// <summary>
        /// Products
        /// </summary>
        public IEnumerable<DomainModels.VehicleMaker> VehicleMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
