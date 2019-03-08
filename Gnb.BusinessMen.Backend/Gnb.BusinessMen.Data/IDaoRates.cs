using System;
using System.Collections.Generic;
using Gnb.BusinessMen.Model;

namespace Gnb.BusinessMen.Data
{
    /// <summary>
    /// DAO rates.
    /// </summary>
    public interface IDaoRates
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        ICollection<Rates> GetAll();
    }
}
