using System.Collections.Generic;
using Gnb.BusinessMen.Model;

namespace Gnb.BusinessMen.Service
{
    /// <summary>
    /// Service rates.
    /// </summary>
    public interface IServiceRates
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        ICollection<Rates> GetAll();
    }
}