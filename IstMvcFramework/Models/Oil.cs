namespace IstMvcFramework.Models
{
    public class Oil
    {
        public int OilId { get; set; }
        public string OilName { get; set; }
        public int? OilMakerId { get; set; }
        public int? OilAverageMilage { get; set; }
        public string OilPower { get; set; }
        public double? OilPrice { get; set; }
        public string OilDescription { get; set; }
        public int? OilNetWeightId { get; set; }
        public string OilMakerCompanyName { get; set; }
    }
}