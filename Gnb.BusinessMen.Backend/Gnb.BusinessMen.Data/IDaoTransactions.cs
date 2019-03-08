using System;
using System.Collections.Generic;
using Gnb.BusinessMen.Model;

namespace Gnb.BusinessMen.Data
{
    /// <summary>
    /// DAO transactions.
    /// </summary>
    public interface IDaoTransactions
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        ICollection<Transactions> GetAll();

        /// <summary>
        /// Gets the total by sku.
        /// </summary>
        /// <returns>The total by sku.</returns>
        /// <param name="sku">Sku.</param>
        ICollection<Transactions> GetTotalBySku(string sku);
    }
}
