using MainDomain = Models.DomainModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilResponseMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.Oil CreateFrom(this MainDomain.Oil source)
        {
            return new Models.Oil
            {
                OilId = source.OilId,
                OilAverageMilage = source.OilAverageMilage,
                OilDescription = source.OilDescription,
                OilMakerId = source.OilMakerId,
                OilName = source.OilName,
                OilNetWeightId = source.OilNetWeightId,
                OilPower = source.OilPower,
                OilPrice = source.OilPrice
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.Oil CreateFrom(this Models.Oil source)
        {
            return new MainDomain.Oil
            {
                OilId = source.OilId,
                OilAverageMilage = source.OilAverageMilage,
                OilDescription = source.OilDescription,
                OilMakerId = source.OilMakerId,
                OilName = source.OilName,
                OilNetWeightId = source.OilNetWeightId,
                OilPower = source.OilPower,
                OilPrice = source.OilPrice
            };

        }

        #endregion
    }
}