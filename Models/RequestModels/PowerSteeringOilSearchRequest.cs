namespace Models.RequestModels
{
    public class PowerSteeringOilSearchRequest: GetPagedListRequest
    {
        public int? PowerSteeringOilId { get; set; }
    }
}
