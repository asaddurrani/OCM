using System;
using System.Net;
using System.Web;
using System.Web.Http;
using Interfaces.IServices;
using IstMvcFramework.ModelMappers;
using IstMvcFramework.Models;
using IstMvcFramework.Models.Response;
using MainDomain = Models.RequestModels;


namespace IstMvcFramework.Areas.Api.Controllers
{
    public class PowerSteeringOilController : ApiController
    {
         private readonly IPowerSteeringOilService _powerSteeringOilService;
         public PowerSteeringOilController(IPowerSteeringOilService powerSteeringOilService)
        {
            _powerSteeringOilService = powerSteeringOilService;
            if (powerSteeringOilService == null)
            {
                throw new ArgumentNullException("powerSteeringOilService");
            }

             this._powerSteeringOilService = powerSteeringOilService;
        }
        /// <summary>
        /// Get All
        /// </summary>
         public AirFilterResponse Get([FromUri] MainDomain.AirFilterSearchRequest request)
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