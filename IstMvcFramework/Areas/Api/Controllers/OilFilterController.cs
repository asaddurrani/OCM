using System;
using System.Linq;
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
    public class OilFilterController : ApiController
    {
        private readonly IOilFilterService _oilFilterService;
        public OilFilterController(IOilFilterService oilFilterService)
        {
            if (oilFilterService == null)
            {
                throw new ArgumentNullException("oilFilterService");
            }

            this._oilFilterService = oilFilterService;
        }
        /// <summary>
        /// Get All
        /// </summary>
        public OilFilterResponse Get([FromUri] MainDomain.OilFilterSearchRequest request)
        {
            if (request == null || !ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            var result = _oilFilterService.GetAllOilFilters();
            return new OilFilterResponse
            {
                OilFilters = result.OilFilters.Select(x => x.CreateFrom()),
                TotalCount = result.TotalCount
            };
        }

        //[ApiException]
        [HttpPost]
        public Models.OilFilter Post(Models.OilFilter oil)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpException((int)HttpStatusCode.BadRequest, "Invalid Request");
            }
            return _oilFilterService.Save(oil.CreateFrom()).CreateFrom();
        }
	}
}