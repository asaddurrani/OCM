using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface IOilRepository : IBaseRepository<Models.DomainModels.Oil, int>
    {
    }
}
