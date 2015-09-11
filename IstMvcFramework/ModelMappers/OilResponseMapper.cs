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

        #region Air Filter
        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.AirFilter CreateFrom(this MainDomain.AirFilter source)
        {
            return new Models.AirFilter
            {
                AilFilterId = source.AilFilterId,
                AirFilterName = source.AirFilterName,
                AirFilterPrice = source.AirFilterPrice
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.AirFilter CreateFrom(this Models.AirFilter source)
        {
            return new MainDomain.AirFilter
            {

                AilFilterId = source.AilFilterId,
                AirFilterName = source.AirFilterName,
                AirFilterPrice = source.AirFilterPrice
            };

        }
        #endregion

        #region OilFilter
        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.OilFilter CreateFrom(this MainDomain.OilFilter source)
        {
            return new Models.OilFilter
            {
                OilFilterId = source.OilFilterId,
                OilFilterName = source.OilFilterName,
                OilFilterPrice = source.OilFilterPrice,
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.OilFilter CreateFrom(this Models.OilFilter source)
        {
            return new MainDomain.OilFilter
            {
                OilFilterId = source.OilFilterId,
                OilFilterName = source.OilFilterName,
                OilFilterPrice = source.OilFilterPrice,
            };

        }
        #endregion

        #region Brake Oil
        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.BrakeOil CreateFrom(this MainDomain.BrakeOil source)
        {
            return new Models.BrakeOil
            {
                BrakeOilId = source.BrakeOilId,
                BrakeOilCompanyName = source.BrakeOilCompanyName,
                BrakeOilName = source.BrakeOilName,
                BrakeOilPrice = source.BrakeOilPrice            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.BrakeOil CreateFrom(this Models.BrakeOil source)
        {
            return new MainDomain.BrakeOil
            {
                BrakeOilId = source.BrakeOilId,
                BrakeOilCompanyName = source.BrakeOilCompanyName,
                BrakeOilName = source.BrakeOilName,
                BrakeOilPrice = source.BrakeOilPrice
            };

        }
        #endregion

        #region Power Sterring Oil
        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.PowerSterringOil CreateFrom(this MainDomain.PowerSterringOil source)
        {
            return new Models.PowerSterringOil
            {
                PowerStereringOilId    = source.PowerStereringOilId,
                PowerSterringOilCompany = source.PowerSterringOilCompany,
                PowerSterringOilName = source.PowerSterringOilName,
                PowerSterringOilPrice = source.PowerSterringOilPrice
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.PowerSterringOil CreateFrom(this Models.PowerSterringOil source)
        {
            return new MainDomain.PowerSterringOil
            {
                PowerStereringOilId = source.PowerStereringOilId,
                PowerSterringOilCompany = source.PowerSterringOilCompany,
                PowerSterringOilName = source.PowerSterringOilName,
                PowerSterringOilPrice = source.PowerSterringOilPrice
            };

        }
        #endregion
    }
}