using System.Collections.Generic;
using Gnb.BusinessMen.Model;

namespace Gnb.BusinessMen.Service
{
    /// <summary>
    /// Service transactions.
    /// </summary>
    public interface IServiceTransactions
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        ICollection<Transactions> GetAll();
    }
}