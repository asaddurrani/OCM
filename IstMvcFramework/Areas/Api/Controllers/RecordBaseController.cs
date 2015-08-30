using System;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Interfaces.IServices;
using IstMvcFramework.ModelMappers;
using IstMvcFramework.Models;
using MainDomain = Models.RequestModels;

namespace IstMvcFramework.Areas.Api.Controllers
{
    public class RecordBaseController : ApiController
    {
        private readonly IOilService _oilService;
        private readonly IOilMakerService _oilMakerService;
        private readonly IVehicleMakerService _vehicleMakerService;
        private readonly IVehicleModelMakerService _vehicleModelMakerService;
        public RecordBaseController(IOilService oilService, IOilMakerService oilMakerService, IVehicleMakerService vehicleMakerService, IVehicleModelMakerService vehicleModelMakerService)
        {
            if (oilService == null)
            {
                throw new ArgumentNullException("oilService");
            }

            this._oilService = oilService;
            this._oilMakerService = oilMakerService;
            this._vehicleMakerService = vehicleMakerService;
            this._vehicleModelMakerService = vehicleModelMakerService;
        }
        /// <summary>
        /// Get All
        /// </summary>
        public Models.RecordBaseData Get()
        {
            return new RecordBaseData
            {
                OilMakerCompanies = _oilMakerService.GetAllOilMakers().OilMakers.Select(x=>x.CreateFrom()),
                Oils = _oilService.GetAllOils().Oils.Select(x=>x.CreateFrom()),
                VehicleMakers = _vehicleMakerService.GetAllVehicleMakers().VehicleMakers.Select(x=>x.CreateFrom()),
                VehicleModelMaker = _vehicleModelMakerService.GetAllVehicleModelMakers(new MainDomain.VehicleModelMakerSearchRequest()).VehicleModelMakers.Select(x=>x.CreateFrom())
            };
        }
	}
}