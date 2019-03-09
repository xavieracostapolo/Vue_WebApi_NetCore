using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Gnb.BusinessMen.Model;
using Gnb.BusinessMen.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gnb.BusinessMen.Api.Controllers
{
    [Route("api/[controller]")]
    public class TransactionsController : Controller
    {
        /// <summary>
        /// The service transactions.
        /// </summary>
        private readonly IServiceTransactions serviceTransactions;

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<TransactionsController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Api.Controllers.TransactionsController"/> class.
        /// </summary>
        /// <param name="serviceTransactions">Service transactions.</param>
        public TransactionsController(IServiceTransactions serviceTransactions, ILogger<TransactionsController> logger)
        {
            this.serviceTransactions = serviceTransactions;
            this._logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Transactions> Get()
        {
            try
            {
                return this.serviceTransactions.GetAll();
            }
            catch (ServiceException ex)
            {
                _logger.LogError(ex.StackTrace);
                return new Collection<Transactions>();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Transactions> Get(string id)
        {
            try
            {
                return this.serviceTransactions.GetTotalBySku(id);
            }
            catch (ServiceException ex)
            {
                _logger.LogError(ex.StackTrace);
                return new Collection<Transactions>();
            }
        }

        // GET api/values/5
        [HttpGet("GetSumTotal/{id}")]
        public decimal GetSumTotal(string id)
        {
            try
            {
                return this.serviceTransactions.GetSumTotalBySku(id);
            }
            catch (ServiceException ex)
            {
                _logger.LogError(ex.StackTrace);
                return -1;
            }
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
