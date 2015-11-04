using System;
using System.Net;
using System.Web;
using System.Web.Http;
using Interfaces.IServices;
using IstMvcFramework.ModelMappers;
using IstMvcFramework.Models;
using MainDomain = Models.RequestModels;

namespace IstMvcFramework.Areas.Api.Controllers
{
    public class AirFilterController : ApiController
    {
         private readonly IAirFilterService _airFilterService;
         public AirFilterController(IAirFilterService airFilterService)
        {
             _airFilterService = airFilterService;
             if (airFilterService == null)
            {
                throw new ArgumentNullException("airFilterService");
            }

             this._airFilterService = airFilterService;
        }
        /// <summary>
        /// Get All
        /// </summary>
         public Models.AirFilterResponse Get([FromUri] MainDomain.AirFilterSearchRequest request)
        {
            if (request == null || !ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            return _airFilterService.GetAllAirFilters().CreateFrom();
        }

        //[ApiException]
        [HttpPost]
        public Models.AirFilter Post(Models.AirFilter oil)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            return _airFilterService.Save(oil.CreateFrom()).CreateFrom();
        }
	}
}