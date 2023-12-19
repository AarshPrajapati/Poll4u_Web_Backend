using Poll4u_Web_BOL;
using Poll4u_Web_DAL;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poll4u_Web_BAL
{
    public class Admin_User_BAL
    {
        public int Admin_Login(Admin a)
        {
            Admin_User_DAL Login = new Admin_User_DAL();
            return Login.admin_Login(a);
        }
        public List<User> Get_LastweekUser()
        {
            Admin_User_DAL data = new Admin_User_DAL();
            return data.lastweekuser();
        }
        public List<User> Get_AllUser()
        {
            Admin_User_DAL Users = new Admin_User_DAL();
            return Users.AllUser_Data();
        }

       
        public List<User> Details_User(int id)
        {
            Admin_User_DAL dUser = new Admin_User_DAL();
            return dUser.UserDetail(id);
        }

        public List<User> Get_RemovedUser()
        {
            Admin_User_DAL rem_users = new Admin_User_DAL();
            return rem_users.RemovedUser_Data(); 
        }

        public void RemoveUser(int id)
        {
            Admin_User_DAL remove = new Admin_User_DAL();
            remove.RemoveUser(id);
        }
        public void unbanUser(int id)
        {
            Admin_User_DAL unban = new Admin_User_DAL();
            unban.unbanUser(id);
        }

        public List<chart> UserChart()
        {
            Admin_User_DAL Chart = new Admin_User_DAL();
            return Chart.UserChart();
        }
    }
}
