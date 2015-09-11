using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IPowerSterringOilRepository : IBaseRepository<Models.DomainModels.PowerSterringOil, int>
    {
        PowerSterringOilResponse GetAllOils();
        PowerSterringOil GetPowerSterringOilById(int id);

    }
}
