﻿using Models.ResponseModels;

namespace Interfaces.IServices
{
    public interface IPowerSteeringOilService
    {
        PowerSterringOilResponse GetAllPowerSterringOils();
        Models.DomainModels.PowerSterringOil GetPowerSterringOilById(int id);
    }
}