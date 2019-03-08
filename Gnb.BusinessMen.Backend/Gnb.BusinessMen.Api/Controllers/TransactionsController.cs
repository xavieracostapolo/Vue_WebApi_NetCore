using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gnb.BusinessMen.Model;
using Gnb.BusinessMen.Service;
using Microsoft.AspNetCore.Mvc;

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
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Api.Controllers.TransactionsController"/> class.
        /// </summary>
        /// <param name="serviceTransactions">Service transactions.</param>
        public TransactionsController(IServiceTransactions serviceTransactions)
        {
            this.serviceTransactions = serviceTransactions;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Transactions> Get()
        {
            return this.serviceTransactions.GetAll();
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
