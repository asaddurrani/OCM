using System.Collections.Generic;

namespace IstMvcFramework.Models
{
    public class OilFilterMakerCompany
    {
        public int OilFilterMakerCompanyId { get; set; }
        public string OilFilterMakerCompanyName { get; set; }
        public string OilFilterMakerCompanyDescription { get; set; }

        public virtual ICollection<OilFilter> OilFilters { get; set; }
    }
}