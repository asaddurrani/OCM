using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IstMvcFramework.Models
{
    public class RecordModel
    {
        public int OilId { get; set; }
        public string OilName { get; set; }
        public int? OilMakerId { get; set; }
        public int? OilAverageMilage { get; set; }
        public string OilPower { get; set; }
        public double? OilPrice { get; set; }
        public int? OilNetWeightId { get; set; }

        //
        public string OilMakerName { get; set; }

        //
        public long VehicleId { get; set; }
        public long? VehicleMakerId { get; set; }
        public string VehicleModelName { get; set; }
        public long? FuilingTypeId { get; set; }
        public string VehicleMakerName { get; set; }
    }
}