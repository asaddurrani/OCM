﻿using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IOilMakerCompanyRepository : IBaseRepository<Models.DomainModels.OilMakerCompany, int>
    {
        OilMakerResponce GetAllOilMakers();
        Models.DomainModels.OilMakerCompany GetOilMakerCompanyById(int id);
    }
}
