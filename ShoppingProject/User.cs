using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject
{
    /// <summary>
    /// This class represents user info
    /// </summary>
    public class User
    
    {
        #region Variables
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        public int AccountNumber { get; private set; }

        public string Name { get; set; }
        [Key]
        public string EmailAddress { get; set; }

        public string Address { get; set; }
        #endregion

        #region Constructors
        public User()
            {
            AccountNumber = ++lastAccountNumber;
            }
        public User(string name) : this()
        {
            Name = name;
        }
        public User (string name,string emailadd,string addr) : this(name)
        {
            EmailAddress = emailadd;
            Address = addr;
        }
            

        
        #endregion
    }

}
