using System.Linq;
using IstMvcFramework.Models.Response;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class PowerSteeringOilResponseMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static PowerSteeringOilResponse CreateFrom(this MainDomain.PowerSterringOilResponse source)
        {
            return new PowerSteeringOilResponse
            {
                TotalCount = source.TotalCount,
                PowerSterringOils = source.PowerSterringOils.Select(p => p.CreateFrom())
            };

        }

        #endregion
    }
}