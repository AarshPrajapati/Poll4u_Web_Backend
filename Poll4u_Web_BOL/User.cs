using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Poll4u_Web_BOL
{
    public class User_Signup
    {
        public int user_id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
       //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
    public class User
    {
        public int user_id { get; set; }
        public string profile { get; set; }

        public string Profile_Action { get; set; }

        public int otp { get; set; }

        public HttpPostedFileBase save_Profile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
        public string Username { get; set; }
        public string E_Mail { get; set; }
        public int status { get; set; }

        public int banned { get; set; }
        public DateTime Date { get; set; }

        public int TotalUser { get; set; }
        public int Total_followers { get; set; }

    }

    public class chart
    {
        public DateTime Date { get; set; }
        public int TotalUser { get; set; }
        public int ActivePoll { get; set; }
        public int Total { get; set; }
        public int ActiveUser { get; set; }
        public int TotalPolls { get; set; }
    }
}
