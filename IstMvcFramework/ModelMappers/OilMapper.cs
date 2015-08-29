using System.Linq;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class OilMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static Models.OilResponse CreateFrom(this MainDomain.OilResponse source)
        {
            return new Models.OilResponse
            {
                TotalCount = source.TotalCount,
                Oils = source.Oils.Select(p => p.CreateFrom())
            };

        }

        #endregion
    }
}