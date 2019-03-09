using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Gnb.BusinessMen.Data;
using Gnb.BusinessMen.Model;
using Gnb.BusinessMen.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gnb.BusinessMen.Api.Controllers
{
    [Route("api/[controller]")]
    public class RatesController : Controller
    {
        /// <summary>
        /// The service rates.
        /// </summary>
        private readonly IServiceRates serviceRates;

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<RatesController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Api.Controllers.RatesController"/> class.
        /// </summary>
        public RatesController(IServiceRates serviceRates, ILogger<RatesController> logger)
        {
            this.serviceRates = serviceRates;
            this._logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Rates> Get()
        {
            try
            {
                return serviceRates.GetAll();
            }
            catch (ServiceException ex)
            {
                _logger.LogError(ex.StackTrace);
                return new Collection<Rates>();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
