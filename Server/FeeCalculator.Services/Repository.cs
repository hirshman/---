using FeeCalculator.Core.Models;
using FeeCalculator.Core.Services;
using Newtonsoft.Json.Linq;
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

        private string _JsonFile;

        #endregion

        #region Constructor

        public Repository()
        {
            //TODO need to get the file from constructor function
            var connectionString = "../Data/Fees.json";

             _JsonFile = File.ReadAllText(connectionString);
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
            //TODO
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


        Fee IRepository<T>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fee> GetByCategory(int categoryId)
        {
            var fees = new List<Fee>();
            try
            {
                var jObject = JObject.Parse(_JsonFile);
                if (jObject != null)
                {
                    JArray feeArrary = (JArray)jObject["fees"];
                    if (feeArrary != null)
                    {
                        foreach (var item in feeArrary)
                        {
                            fees.Add(new Fee
                            {
                                CategoryId= Convert.ToInt32(item["categoryId"]),
                                Id = Convert.ToInt32(item["id"]), 
                                Name = item["name"].ToString(),
                                Description =item["description"].ToString(),
                                AmountPerUnit= Convert.ToInt32(item["amountPerUnit"]),
                                MeasureType= item["measureType"].ToString()
                            });
                        }

                    }
                    return fees.Where(x=> x.CategoryId==categoryId);
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = new List<Category>();
            try
            {
                var jObject = JObject.Parse(_JsonFile);
                if (jObject != null)
                {
                    JArray CategoryArrary = (JArray)jObject["categories"];
                    if (CategoryArrary != null)
                    {
                        foreach (var item in CategoryArrary)
                        {
                            categories.Add(new Category{ Id = Convert.ToInt32(item["id"]), Name = item["name"].ToString() });
                        }

                    }
                    return categories;
                }
                return categories;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
