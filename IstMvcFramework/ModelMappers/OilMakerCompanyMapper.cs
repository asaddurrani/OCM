using System.Linq;
using IstMvcFramework.Models.Response;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilMakerCompanyMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static OilMakerResponse CreateFrom(this MainDomain.OilMakerResponce source)
        {
            return new OilMakerResponse
            {
                TotalCount = source.TotalCount,
                OilMakerCompanies = source.OilMakers.Select(p => p.CreateFrom())
            };

        }

        #endregion
    }
}