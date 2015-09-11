using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class BrakeOilResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BrakeOilResponse()
        {
            BrakeOils = new List<DomainModels.BrakeOil>();
        }

        /// <summary>
        /// Brake Oils
        /// </summary>
        public IEnumerable<DomainModels.BrakeOil> BrakeOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
