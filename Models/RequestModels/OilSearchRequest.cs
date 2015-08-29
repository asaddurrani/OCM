namespace Models.RequestModels
{
    public class OilSearchRequest : GetPagedListRequest
    {
        public int OilId { get; set; }
    }
}
