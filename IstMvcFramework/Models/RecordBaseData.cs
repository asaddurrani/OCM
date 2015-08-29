using System.Collections.Generic;

namespace IstMvcFramework.Models
{
    public class RecordBaseData
    {
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.Oil> Oils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int OilsTotalCount { get; set; }
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.OilMakerCompany> OilMakerCompanies { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int OilMakerCompaniesTotalCount { get; set; }
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.VehicleMaker> VehicleMakers { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int VehicleMakersTotalCount { get; set; }
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.VehicleModelMaker> VehicleModelMaker { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int VehicleModelMakerTotalCount { get; set; }
    }
}