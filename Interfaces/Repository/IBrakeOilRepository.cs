using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IBrakeOilRepository : IBaseRepository<Models.DomainModels.BrakeOil, int>
    {
        BrakeOilResponse GetAllBrakeOils();
        BrakeOil GetBrakeOilById(int id);
    }
}
