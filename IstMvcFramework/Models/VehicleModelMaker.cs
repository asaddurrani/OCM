namespace IstMvcFramework.Models
{
    public class VehicleModelMaker
    {
        public long VehicleId { get; set; }
        public long? VehicleMakerId { get; set; }
        public string VehicleModelName { get; set; }
        public long? FuilingTypeId { get; set; }
        public string VehicleMakerName { get; set; }
        public virtual Models.VehicleMaker VehicleMaker { get; set; }
    }
}