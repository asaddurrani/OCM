using System.Linq;
using IstMvcFramework.Models;
using IstMvcFramework.Models.Response;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilFilterMakerResponseMapper
    {

        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.Response.OilFilterMakerResponse CreateFrom(this MainDomain.OilFilterMakerResponse source)
        {
            return new Models.Response.OilFilterMakerResponse
            {
                TotalCount = source.TotalCount,
                OilFilterMakerCompanies = source.OilFilterMakerCompanies.Select(x=>x.CreateFrom())
            };

        }

        #endregion
    }
}