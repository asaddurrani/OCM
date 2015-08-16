using System;

namespace IstMvcFramework.Models
{
    public class VehicleMaker
    {
        public long VehicleMakerId { get; set; }
        public string VehicleMakerName { get; set; }
        public DateTime? RecordCreatedDate { get; set; }
        public long? RecCreatedBy { get; set; }
    }
}