namespace Models.RequestModels
{
    public class OilFilterSearchRequest : GetPagedListRequest
    {
        public int? OilFilterId { get; set; }
        public int? OilFilterMakerCompany { get; set; }
    }
}
