using System.Collections.Generic;

namespace IstMvcFramework.Models.Response
{
    public class PowerSteeringOilResponse
    {
        /// <summary>
        /// Power Steering Oils
        /// </summary>
        public IEnumerable<Models.PowerSterringOil> PowerSterringOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}