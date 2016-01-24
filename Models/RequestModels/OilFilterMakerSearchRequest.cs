namespace Models.RequestModels
{
    public class OilFilterMakerSearchRequest : GetPagedListRequest
    {
        public int? OilId { get; set; }
        public int? OilMakerCompany { get; set; }
    }
}
