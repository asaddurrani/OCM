﻿using Interfaces.IServices;
using Interfaces.Repository;
using Models.DomainModels;
using Models.ResponseModels;

namespace Implementation.Services
{
    public class OilService: IOilService
    {
        private readonly IOilRepository _oilRepository;

        public OilService(IOilRepository oilRepository)
        {
            this._oilRepository = oilRepository;

        }

        public OilResponse GetAllOils(Models.RequestModels.OilSearchRequest request)
        {
            return _oilRepository.GetAllOils(request);
        }

        public OilResponse GetAll()
        {
            return _oilRepository.GetAllRecords();
        }

        public Oil GetOilById(int id)
        {
            return _oilRepository.GetOilById(id);
        }
        public Oil Save(Oil oil)
        {
            var oilReturn = _oilRepository.Save(oil);
            return oilReturn;
        }

       
    }
}
