using System.Linq;
using IstMvcFramework.Models.Response;
using MainDomain = Models.ResponseModels;
using Domain = Models.DomainModels;

namespace IstMvcFramework.ModelMappers
{
    public static class VehicleModelMakerMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static VehicleModelMakerResponse CreateFrom(this MainDomain.VehicleModelMakerResponse source)
        {
            return new VehicleModelMakerResponse
            {
                TotalCount = source.TotalCount,
                VehicleModelMakers = source.VehicleModelMakers.Select(p => p.CreateFrom())
            };

        }
        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.VehicleModelMaker CreateFrom(this Domain.VehicleModelMaker source)
        {
            return new Models.VehicleModelMaker
            {
                VehicleMakerId = source.VehicleMakerId,
                FuilingTypeId = source.FuilingTypeId,
                VehicleId = source.VehicleId,
                VehicleModelName = source.VehicleModelName,
                VehicleMakerName = source.VehicleMaker != null? source.VehicleMaker.VehicleMakerName: string.Empty
            };
        }

        /// <summary>
        ///  Create entity from web model
        /// </summary>
        public static Domain.VehicleModelMaker CreateFrom(this Models.VehicleModelMaker source)
        {
            return new Domain.VehicleModelMaker
            {
                FuilingTypeId = source.FuilingTypeId,
                VehicleId = source.VehicleId,
                VehicleMakerId = source.VehicleMakerId,
                VehicleModelName = source.VehicleModelName
            };

        }

        #endregion
    }
}