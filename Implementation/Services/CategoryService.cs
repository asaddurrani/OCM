using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Operation;
using Interfaces.Repository;
using Models.DomainModels;

namespace Implementation.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _icategoryRepository;

          public CategoryService(ICategoryRepository categoryRepository)
        {
            this._icategoryRepository = categoryRepository;

        }

        public IEnumerable<Category> LoadAllCategories()
        {

            return _icategoryRepository.GetAllCategories();
        }
    }
}
