using System;
namespace Gnb.BusinessMen.Model
{
    /// <summary>
    /// Rates.
    /// </summary>
    public class Rates
    {
        /// <summary>
        /// The From.
        /// </summary>
        private string from;

        /// <summary>
        /// The To.
        /// </summary>
        private string to;

        /// <summary>
        /// The rate.
        /// </summary>
        private decimal rate;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Gnb.BusinessMen.Data.Rates"/> class.
        /// </summary>
        public Rates()
        {
        }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>From.</value>ﬁ
        public string From { get => from; set => from = value; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>To.</value>
        public string To { get => to; set => to = value; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>The rate.</value>
        public decimal Rate { get => rate; set => rate = value; }
    }
}
