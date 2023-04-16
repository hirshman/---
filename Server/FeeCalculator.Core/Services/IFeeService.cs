using FeeCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeCalculator.Core.Services
{
    public interface IFeeService
    {
        IEnumerable<Fee> GetByCategory(int categoryId);
        IEnumerable<Category> GetAllCategories();
    }
}
