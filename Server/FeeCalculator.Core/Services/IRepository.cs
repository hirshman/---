using FeeCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeCalculator.Core.Services
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Func<T, bool> predicate);
        T Get(int id);
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        //IEnumerable<T> GetAllDetach(Func<T, bool> predicate = null);
       //int ExecuteSql(string sSql, params object[] pars);
        //int ExecuteGetNewIndex(string prefix);
        //T SQLQuery(string sSql, params object[] pars);
        //void BeginTransaction();
        //bool EndTransaction();
        //void RollBack();
    }
}
