using FeeCalculator.Core.Models;
using FeeCalculator.Core.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Core.Enums;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FeeCalculator.Services
{
    public class FeeService : IFeeService
    {
        #region Variables

        private readonly ILoggerService _loggerService;
        
        private readonly IRepository _repository;

        #endregion

        #region Constructor

        public FeeService(ILoggerService loggerService,IRepository repository)
        {
            _loggerService = loggerService;
            _repository = repository;
            
        }

        #endregion

        #region Public methods

        public IEnumerable<Fee> GetByCategory(int categoryId)
        {
            //TODO try catch
            var fees = _repository.GetByCategory(categoryId);
            return fees;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            //TODO try catch
            var catogries = _repository.GetAllCategories();
            return catogries;
        }
        #endregion

        #region Private methods



        #endregion

    }
}
