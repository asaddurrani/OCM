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
    public class OilFilterMakerController : ApiController
    {
        private readonly IOilFilterMakerService _oilFilterMakerService;

        public OilFilterMakerController(IOilFilterMakerService oilFilterMakerService)
        {
            _oilFilterMakerService = oilFilterMakerService;
        }

        public Models.Response.OilFilterMakerResponse Get()
        {
            return _oilFilterMakerService.GetAll().CreateFrom();
        }
    }
}