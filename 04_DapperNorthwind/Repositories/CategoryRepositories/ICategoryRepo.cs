using _04_DapperNorthwind.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DapperNorthwind.Repositories.CategoryRepositories
{
    public interface ICategoryRepo
    {
        Task<List<ResultCategoryDTO>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDTO category);
        Task UpdateCategoryAsync(UpdateCategoryDTO category);
        Task DeleteCategoryAsync(int categoryId);
        Task<GetByIdCategoryDTO> GetByIdCategoryAsync(int categoryId);
    }
}
