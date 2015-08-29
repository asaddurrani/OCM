namespace Models.RequestModels
{
    public class OilMakerSearchRequest : GetPagedListRequest
    {
        public int OilMakerId { get; set; }
    }
}
