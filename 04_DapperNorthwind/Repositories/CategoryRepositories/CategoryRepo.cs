using _04_DapperNorthwind.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DapperNorthwind.Repositories.CategoryRepositories
{
    public class CategoryRepo : ICategoryRepo
    {
        public Task CreateCategoryAsync(CreateCategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDTO>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDTO> GetByIdCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDTO category)
        {
            throw new NotImplementedException();
        }
    }
}
