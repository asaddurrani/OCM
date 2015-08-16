using System.Collections.Generic;

namespace Models.DomainModels
{
    public class OilMakerCompany
    {
        public int OilMakerId { get; set; }
        public string OilMakerName { get; set; }

        public virtual ICollection<Oil> Oils { get; set; }
    }
}
