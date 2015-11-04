namespace Models.RequestModels
{
    public class AirFilterSearchRequest : GetPagedListRequest
    {
        public int? AirFilterId { get; set; }
    }
}
