using FeeCalculator.Core.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeCalculator.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Variables

        //var json = File.ReadAllText(jsonFile);

        #endregion

        #region Constructor

        public Repository()
        {
            
        }

        #endregion

        #region Public methods

        public void Add(T entity)
        {
            
        }

        public void Update(T entity)
        {
            
        }

        public void Delete(T entity)
        {
           
        }

        public T Get(System.Func<T, bool> predicate)
        {

            //var obj = new T();
            
            return null;

        }

        public T Get(int id)
        {
            
            return null;
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                return null;
            }
            return null;
        }

        #endregion
    }
}
