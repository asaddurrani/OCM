using System.Collections.Generic;

namespace Models.DomainModels
{
    public class VehicleModelMaker
    {
        public long VehicleId { get; set; }
        public long? VehicleMakerId { get; set; }
        public string VehicleModelName { get; set; }
        public long? FuilingTypeId { get; set; }

        public virtual Models.DomainModels.VehicleMaker VehicleMaker { get; set; }
        public virtual ICollection<Models.DomainModels.VehicleMaker> CustomerVehicles { get; set; }
    }
}
