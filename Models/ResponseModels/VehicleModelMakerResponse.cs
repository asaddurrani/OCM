using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class VehicleModelMakerResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public VehicleModelMakerResponse()
        {
            VehicleModelMakers = new List<DomainModels.VehicleModelMaker>();
        }

        /// <summary>
        /// Products
        /// </summary>
        public IEnumerable<DomainModels.VehicleModelMaker> VehicleModelMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
