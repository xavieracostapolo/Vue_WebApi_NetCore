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

        /// <summary>
        /// Gets the total by sku.
        /// </summary>
        /// <returns>The total by sku.</returns>
        /// <param name="sku">Sku.</param>
        ICollection<Transactions> GetTotalBySku(string sku);

        /// <summary>
        /// Gets the sum total by sku.
        /// </summary>
        /// <returns>The sum total by sku.</returns>
        /// <param name="sku">Sku.</param>
        decimal GetSumTotalBySku(string sku);
    }
}