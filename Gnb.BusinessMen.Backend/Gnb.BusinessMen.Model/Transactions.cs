using System;
namespace Gnb.BusinessMen.Model
{
    /// <summary>
    /// Transactions.
    /// </summary>
    public class Transactions
    {
        /// <summary>
        /// The sku.
        /// </summary>
        private string sku;

        /// <summary>
        /// The amount.
        /// </summary>
        private decimal amount;

        /// <summary>
        /// The currency.
        /// </summary>
        private string currency;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Data.Transactions"/> class.
        /// </summary>
        public Transactions()
        {
        }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        /// <value>The sku.</value>
        public string Sku { get => sku; set => sku = value; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public decimal Amount { get => amount; set => amount = value; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string Currency { get => currency; set => currency = value; }
    }
}
