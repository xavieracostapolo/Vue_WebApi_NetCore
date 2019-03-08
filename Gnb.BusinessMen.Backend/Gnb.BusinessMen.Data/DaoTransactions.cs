using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        public ICollection<Transactions> GetTotalBySku(string sku)
        {
            throw new NotImplementedException();
        }
    }
}
