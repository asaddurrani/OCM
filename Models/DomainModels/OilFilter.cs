namespace Models.DomainModels
{
    public class OilFilter
    {
        public int OilFilterId { get; set; }
        public string OilFilterName { get; set; }
        public double OilFilterPrice { get; set; }
        public int? OilFilterMakerCompanyId { get; set; }
    }
}
