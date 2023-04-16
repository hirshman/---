using FeeCalculator.Core.Models;
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

        private readonly ILogger<FeeController> _logger;
        #endregion
        
        
        #region Constructor
        public FeeController(ILogger<FeeController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Get methods
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Category> GetCategories()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Category
            {
                Id = 1,
                Name="A",
            })
            .ToArray();
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
        public IEnumerable<Fee> Get(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(
                index => new Fee
                {
                   
                })
            .ToArray();
        }
        #endregion
    }
}
