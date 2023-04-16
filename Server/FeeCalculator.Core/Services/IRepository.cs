using FeeCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeCalculator.Core.Services
{
    public interface IRepository
    {
        //void Add(T entity);
        //void Update(T entity);
        //void Delete(T entity);
        //T Get(Func<T, bool> predicate);
       // T Get(int id);

        Fee Get(int id);       
        IEnumerable<Fee> GetByCategory(int categoryId);
        IEnumerable<Category> GetAllCategories();

    }
}
