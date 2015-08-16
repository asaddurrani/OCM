namespace Models.DomainModels
{
    public class OilChangeRecord
    {
        public int OilChangeRecordId { get; set; }
        public int? OilCustomerId { get; set; }
        public int? OilId { get; set; }
        public int? CustomerVehicleId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
