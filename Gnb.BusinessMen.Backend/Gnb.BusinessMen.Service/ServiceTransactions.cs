using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        /// The DAO rates.
        /// </summary>
        private readonly IDaoRates daoRates;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Service.ServiceTransactions"/> class.
        /// </summary>
        public ServiceTransactions(IDaoTransactions dao, IDaoRates daoRates)
        {
            this.daoTransactions = dao;
            this.daoRates = daoRates;
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

        /// <summary>
        /// Gets the sum total by sku.
        /// </summary>
        /// <returns>The sum total by sku.</returns>
        /// <param name="sku">Sku.</param>
        public decimal GetSumTotalBySku(string sku)
        {
            decimal total = 0;
            try
            {
                ICollection<Transactions> list = this.GetTotalBySku(sku);
                total = list.GroupBy(t => t.Currency).Select(group => group.Sum(t => t.Amount)).FirstOrDefault();
            }
            catch (DataException ex)
            {
                throw new ServiceException("Error service get sum by Sku transactions", ex);
            }

            return total;
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
                ICollection<Rates> listRates = daoRates.GetAll();
                list = daoTransactions.GetTotalBySku(sku);
                foreach (var item in list)
                {
                    this.ConvertCurrencyToEur(item, listRates);
                }
            }
            catch (DataException ex)
            {
                throw new ServiceException("Error service get by Sku transactions", ex);
            }

            return list;
        }

        /// <summary>
        /// Converts the currency to eur.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="rates">Rates.</param>
        private void ConvertCurrencyToEur(Transactions item, ICollection<Rates> rates)
        {
            if(item.Currency != "EUR" && (item.Currency == "CAD" || item.Currency == "USD"))
            {
                decimal amountEur = rates
                .Where(r => r.From == item.Currency && r.To == "EUR")
                .Select(r => r.Rate)
                .FirstOrDefault();

                if (amountEur > 0)
                {
                    item.Amount = item.Amount * amountEur;
                    item.Currency = "EUR";
                }
            }
            else
            {
                decimal amountCad = rates
                .Where(r => r.From == item.Currency && r.To == "CAD")
                .Select(r => r.Rate)
                .FirstOrDefault();

                decimal amountCadEur = rates
                .Where(r => r.From == "CAD" && r.To == "EUR")
                .Select(r => r.Rate)
                .FirstOrDefault();

                if (amountCad > 0 && amountCadEur > 0)
                {
                    item.Amount = item.Amount * amountCad;
                    item.Amount = item.Amount * amountCadEur;
                    item.Currency = "EUR";
                }
            }
        }
    }
}
