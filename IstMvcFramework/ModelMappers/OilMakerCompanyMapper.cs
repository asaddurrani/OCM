using System.Linq;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilMakerCompanyMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.OilMakerResponse CreateFrom(this MainDomain.OilMakerResponce source)
        {
            return new Models.OilMakerResponse
            {
                TotalCount = source.TotalCount,
                OilMakerCompanies = source.OilMakers.Select(p => p.CreateFrom())
            };

        }

        #endregion
    }
}