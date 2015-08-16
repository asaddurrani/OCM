﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DomainModels;

namespace Interfaces.Operation
{
    public interface ICategoryService
    {
        IEnumerable<Category> LoadAllCategories();
    }
}
