using System;
using System.Collections.Generic;
using Gnb.BusinessMen.Data;
using Gnb.BusinessMen.Model;

namespace Gnb.BusinessMen.Service
{
    /// <summary>
    /// Service transactions.
    /// </summary>
    public class ServiceTransactions : IServiceTransactions
    {
        /// <summary>
        /// The DAO transactions.
        /// </summary>
        private readonly IDaoTransactions daoTransactions;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Service.ServiceTransactions"/> class.
        /// </summary>
        public ServiceTransactions(IDaoTransactions dao)
        {
            this.daoTransactions = dao;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        public ICollection<Transactions> GetAll()
        {
            try
            {
                return daoTransactions.GetAll();
            }
            catch (DataException ex)
            {
                throw new ServiceException("Error service get all transactions", ex);
            }
        }
    }
}
