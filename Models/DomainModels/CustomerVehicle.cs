namespace Models.DomainModels
{
    public class CustomerVehicle
    {
        public int CustomerVehicleId { get; set; }
        public int CustomerId { get; set; }
        public long? VehicleId { get; set; }
        public string VehiclePlateAlphabets { get; set; }
        public string VehiclePlateNumbers { get; set; }
        public string VehiclePlateYear { get; set; }
        public int? VehicleManufacturingYear { get; set; }
        public int? VehicleDailyRunningKms { get; set; }

        public virtual VehicleModelMaker VehicleModelMaker { get; set; }
    }
}
