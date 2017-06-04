using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject
{
    /// <summary>
    /// This class represents Product info
    /// </summary>
    class Product
    {
        #region Properties
        public string ProductName { get; private set; }

        public int ProductId { get; private set; }

        public string ProductDesc { get; private set; }

        public int ProductPrice { get; private set; }

        public int InStock { get; private set; }
        #endregion

        #region Method
        public int Deposit(int quantity)
        {
            InStock += quantity;
            return InStock;
        }

        public int Withdraw (int quantity)
        {
            InStock -= quantity;
            return InStock;
        }
        #endregion
    }
}
