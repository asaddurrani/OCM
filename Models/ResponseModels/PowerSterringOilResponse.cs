using System.Collections.Generic;

namespace Models.ResponseModels
{
    public sealed class PowerSterringOilResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PowerSterringOilResponse()
        {
            PowerSterringOils = new List<DomainModels.PowerSterringOil>();
        }

        /// <summary>
        /// Power Sterring Oils
        /// </summary>
        public IEnumerable<DomainModels.PowerSterringOil> PowerSterringOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}
