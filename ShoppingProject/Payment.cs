using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject
{
    enum PaymentTypes
    {
        Credit,
        Debit
    }
    /// <summary>
    /// This class represents payment info
    /// </summary>
    class Payment
    {
        #region Properties
        public PaymentTypes PaymentType{ get; set; }

        public int CardNumber { get; set; }

        public string CardName { get; set; }

        public int CCV { get; set; }

        public DateTime ExpDate { get; set; }

        public string CardHolderAddress { get; set; }
        #endregion
    }
}
