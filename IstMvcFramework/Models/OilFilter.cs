using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IstMvcFramework.Models
{
    public class OilFilter
    {
        public int OilFilterId { get; set; }
        public string OilFilterName { get; set; }
        public double OilFilterPrice { get; set; }
        public int OilFilterMakerCompanyId { get; set; }
        public string OilFilterMakerCompanyName { get; set; }
    }
}