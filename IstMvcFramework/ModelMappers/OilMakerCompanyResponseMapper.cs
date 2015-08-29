using MainDomain = Models.DomainModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilMakerCompanyResponseMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.OilMakerCompany CreateFrom(this MainDomain.OilMakerCompany source)
        {
            return new Models.OilMakerCompany
            {
                OilMakerId = source.OilMakerId,
                OilMakerName = source.OilMakerName
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.OilMakerCompany CreateFrom(this Models.OilMakerCompany source)
        {
            return new MainDomain.OilMakerCompany
            {
                OilMakerId = source.OilMakerId,
                OilMakerName = source.OilMakerName
            };

        }

        #endregion
    }
}