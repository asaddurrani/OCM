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
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.AirFilter> AirFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int AirFiltersTotalCount { get; set; }
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.OilFilter> OilFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int OilFiltersTotalCount { get; set; }
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.BrakeOil> BrakeOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int BrakeOilsTotalCount { get; set; }
        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Models.PowerSterringOil> PowerSterringOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int PowerSterringOilsTotalCount { get; set; }
    }
}