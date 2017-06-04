using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject
{
    static class Inter
    {
        private static ShopModel db = new ShopModel();

        public static User CreateAccount(string name,string emailadd,string addr)
        {
            var user = new User(name, emailadd, addr);
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        
    }
}
