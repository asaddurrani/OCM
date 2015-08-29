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
    public class OilMakerController : ApiController
    {
        private readonly IOilMakerService _oilMakerService;
        public OilMakerController(IOilMakerService oilMakerService)
        {
            if (oilMakerService == null)
            {
                throw new ArgumentNullException("oilMakerService");
            }

            this._oilMakerService = oilMakerService;
        }
        /// <summary>
        /// Get All
        /// </summary>
        public Models.OilMakerResponse Get([FromUri] MainDomain.OilMakerSearchRequest request)
        {
            if (request == null || !ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            return _oilMakerService.GetAllOilMakers().CreateFrom();
        }
	}
}