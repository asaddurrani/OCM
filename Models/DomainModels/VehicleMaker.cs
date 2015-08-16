using System;
using System.Collections.Generic;

namespace Models.DomainModels
{
    public class VehicleMaker
    {
    
        public long VehicleMakerId { get; set; }
        public string VehicleMakerName { get; set; }
        public DateTime? RecordCreatedDate { get; set; }
        public long? RecCreatedBy { get; set; }

        public virtual ICollection<Models.DomainModels.VehicleModelMaker> VehicleModelMakers { get; set; }
    }
}
