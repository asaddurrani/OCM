using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    public interface IOilChangeRecordRepository : IBaseRepository<Models.DomainModels.OilChangeRecord, int>
    {
    }
}
