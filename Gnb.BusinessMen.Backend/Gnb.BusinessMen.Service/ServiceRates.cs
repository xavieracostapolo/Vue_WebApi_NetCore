using System;
using System.Collections.Generic;
using Gnb.BusinessMen.Data;
using Gnb.BusinessMen.Model;

namespace Gnb.BusinessMen.Service
{
    /// <summary>
    /// Service rates.
    /// </summary>
    public class ServiceRates : IServiceRates
    {
        /// <summary>
        /// The DAO rates.
        /// </summary>
        private readonly IDaoRates daoRates;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Service.ServiceRates"/> class.
        /// </summary>
        public ServiceRates(IDaoRates dao)
        {
            this.daoRates = dao;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        public ICollection<Rates> GetAll()
        {
            try
            {
                return daoRates.GetAll();
            }
            catch (DataException ex)
            {
                throw new ServiceException("Error service get all rates", ex);
            }
        }
    }
}
