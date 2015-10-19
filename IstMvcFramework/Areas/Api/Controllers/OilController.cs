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
    public class OilController : ApiController
    {
        private readonly IOilService _oilService;
        public OilController(IOilService oilService)
        {
            if (oilService == null)
            {
                throw new ArgumentNullException("oilService");
            }

            this._oilService = oilService;
        }
        /// <summary>
        /// Get All
        /// </summary>
        public Models.OilResponse Get([FromUri] MainDomain.OilSearchRequest request)
        {
            if (request == null || !ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            return _oilService.GetAllOils().CreateFrom();
        }

        //[ApiException]
        [HttpPost]
        public Models.Oil Post(Models.Oil oil)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            return _oilService.Save(oil.CreateFrom()).CreateFrom();
        }
	}
}