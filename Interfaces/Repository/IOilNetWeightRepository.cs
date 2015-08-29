using System.Collections.Generic;
using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Repository
{
    public interface IOilNetWeightRepository : IBaseRepository<Models.DomainModels.OilNetWeight, int>
    {
        IEnumerable<OilNetWeight> GetAllOilNetWeights();
    }
}
