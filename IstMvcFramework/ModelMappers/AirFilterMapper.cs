﻿using System.Linq;
using IstMvcFramework.Models.Response;
using MainDomain = Models.ResponseModels;

namespace IstMvcFramework.ModelMappers
{
    public static class AirFilterMapper
    {
        #region Public

        /// <summary>
        ///  Create web model from entity
        /// </summary>
        public static AirFilterResponse CreateFrom(this MainDomain.AirFilterResponse source)
        {
            return new AirFilterResponse
            {
                TotalCount = source.TotalCount,
                AirFilters = source.AirFilters.Select(p => p.CreateFrom())
            };

        }

        #endregion
    }
}