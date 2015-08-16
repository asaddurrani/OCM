using System.Linq;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class VehicleMakerResponseMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.VehicleMakerResponse CreateFrom(this MainDomain.VehicalMakerResponse source)
        {
            return new Models.VehicleMakerResponse
            {
                TotalCount = source.TotalCount,
                VehicleMakers = source.VehicleMakers.Select(p => p.CreateFrom())
            };
           
        }

        #endregion
    }
}