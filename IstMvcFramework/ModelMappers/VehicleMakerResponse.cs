using MainDomain = Models.DomainModels;

namespace IstMvcFramework.ModelMappers
{
    public static class VehicleMakerResponse
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.VehicleMaker CreateFrom(this MainDomain.VehicleMaker source)
        {
            return new Models.VehicleMaker
            {
                VehicleMakerId = source.VehicleMakerId,
                VehicleMakerName = source.VehicleMakerName,
                RecCreatedBy = source.RecCreatedBy,
                RecordCreatedDate = source.RecordCreatedDate
            };

        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static MainDomain.VehicleMaker CreateFrom(this Models.VehicleMaker source)
        {
            return new MainDomain.VehicleMaker
            {
                VehicleMakerId = source.VehicleMakerId,
                VehicleMakerName = source.VehicleMakerName
            };

        }

        #endregion
    }
}