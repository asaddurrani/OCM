namespace Models.RequestModels
{
    public class VehicleModelMakerSearchRequest : GetPagedListRequest
    {
        public int VehicleMakerId { get; set; }
    }
}
