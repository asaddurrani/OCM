﻿using Models.ResponseModels;
namespace Interfaces.Repository
{
    public interface IOilRepository : IBaseRepository<Models.DomainModels.Oil, int>
    {
        OilResponse GetAllOils();
        Models.DomainModels.Oil GetOilById(int id);
    }
}
