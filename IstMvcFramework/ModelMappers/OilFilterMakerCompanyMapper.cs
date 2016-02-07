using MainDomain = Models.DomainModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilFilterMakerCompanyMapper
    {
        #region Oil Filter Maker Company
        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.OilFilterMakerCompany CreateFrom(this MainDomain.OilFilterMakerCompany source)
        {
            return new Models.OilFilterMakerCompany
            {
                OilFilterMakerCompanyId = source.OilFilterMakerCompanyId,
                OilFilterMakerCompanyDescription = source.OilFilterMakerCompanyDescription,
                OilFilterMakerCompanyName = source.OilFilterMakerCompanyName
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.OilFilterMakerCompany CreateFrom(this Models.OilFilterMakerCompany source)
        {
            return new MainDomain.OilFilterMakerCompany
            {

                OilFilterMakerCompanyId = source.OilFilterMakerCompanyId,
                OilFilterMakerCompanyDescription = source.OilFilterMakerCompanyDescription,
                OilFilterMakerCompanyName = source.OilFilterMakerCompanyName
            };

        }
        #endregion
    }
}