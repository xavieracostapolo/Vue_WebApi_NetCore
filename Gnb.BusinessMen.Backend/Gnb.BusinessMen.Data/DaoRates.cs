using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Gnb.BusinessMen.Model;
using Newtonsoft.Json;

namespace Gnb.BusinessMen.Data
{
    /// <summary>
    /// DAO rates.
    /// </summary>
    public class DaoRates : IDaoRates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Data.DaoRates"/> class.
        /// </summary>
        public DaoRates()
        {
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        public ICollection<Rates> GetAll()
        {
            ICollection<Rates> list = new Collection<Rates>();
            try
            {
                using (StreamReader r = new StreamReader("FileData/rates.json"))
                {
                    string json = r.ReadToEnd();
                    list = JsonConvert.DeserializeObject<List<Rates>>(json);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error dao get all Rates.", ex);
            }

            return list;
        }
    }
}
