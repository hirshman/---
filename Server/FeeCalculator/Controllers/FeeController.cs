using FeeCalculator.Core.Models;
using FeeCalculator.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeeCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeeController : ControllerBase
    {
        #region Variables
        private readonly IFeeService _feeService;
        private readonly ILogger<FeeController> _logger;
        #endregion
        
        
        #region Constructor
        public FeeController(ILogger<FeeController> logger, IFeeService feeService)
        {
            _logger = logger;
            _feeService = feeService;
        }
        #endregion

        #region Get methods
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Category> GetCategories()
        {

            //TODO try catch
            var categories = _feeService.GetAllCategories();
            return categories;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Fee> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(
                index => new Fee
            {
                
            })
            .ToArray();
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("Get/{id:int}")]
        public IEnumerable<Fee> Get(int catogryId)
        {
            //TODO try catch
            var fees = _feeService.GetByCategory(catogryId);
            return fees;
        }
        #endregion
    }
}
