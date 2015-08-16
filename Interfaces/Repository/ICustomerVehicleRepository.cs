using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface ICustomerVehicleRepository : IBaseRepository<Models.DomainModels.CustomerVehicle, int>
    {
    }
}
