using System.Collections.Generic;

namespace Models.DomainModels
{
    public class OilFilterMakerCompany
    {
        public int OilFilterMakerCompanyId { get; set; }
        public string OilFilterMakerCompanyName { get; set; }
        public string OilFilterMakerCompanyDescription { get; set; }

        public virtual ICollection<OilFilter> OilFilters { get; set; }
    }
}
