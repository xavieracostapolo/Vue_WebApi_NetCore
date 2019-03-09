using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Gnb.BusinessMen.Model;
using Newtonsoft.Json;

namespace Gnb.BusinessMen.Data
{
    /// <summary>
    /// DAO transactions.
    /// </summary>
    public class DaoTransactions : IDaoTransactions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Data.DaoTransactions"/> class.
        /// </summary>
        public DaoTransactions()
        {
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>The all.</returns>
        public ICollection<Transactions> GetAll()
        {
            ICollection<Transactions> list = new Collection<Transactions>();
            try
            {
                using (StreamReader r = new StreamReader("FileData/transactions.json"))
                {
                    string json = r.ReadToEnd();
                    list = JsonConvert.DeserializeObject<List<Transactions>>(json);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error dao get all Transactions.", ex);
            }

            return list;
        }

        /// <summary>
        /// Gets the total by sku.
        /// </summary>
        /// <returns>The total by sku.</returns>
        /// <param name="sku">Sku.</param>
        public ICollection<Transactions> GetTotalBySku(string sku)
        {
            ICollection<Transactions> list = new Collection<Transactions>();
            try
            {
                list = this.GetAll()
                    .Where(t => t.Sku == sku)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new DataException("Error dao get by Sku Transactions.", ex);
            }

            return list;
        }
    }
}
