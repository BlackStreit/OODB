using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OODB
{
    internal class DataBase
    {
        String filename = @"C:\Users\Администратор\source\repos\OODB\db.data";
        IObjectContainer db;
        public void dbConnect()
        {
            db = Db4oFactory.OpenFile(filename);
        }
        public void dbClose()
        {
            db.Close();
        }
        public void addUser(User user)
        {
            db.Store(user);
        }
        public List<User> GetUsers()
        {
            IList<User> list = db.Query<User>();
            List<User> result = new List<User>();
            foreach(var l in list)
            {
                result.Add(l);
            }
            return result;
        }
    }
}
