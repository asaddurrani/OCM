﻿using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IOilFilterService
    {
        OilFilterResponse GetAllOilFilters();
        Models.DomainModels.OilFilter GetOilFilterById(int id);
        OilFilter Save(OilFilter oil);
    }
}
