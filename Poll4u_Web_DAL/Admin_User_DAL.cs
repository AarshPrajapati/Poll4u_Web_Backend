using Poll4u_Web_BOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Poll4u_Web_DAL
{
    public class Admin_User_DAL
    {
        string str = ConfigurationManager.ConnectionStrings["Poll4u_Web"].ConnectionString;
        public int admin_Login(Admin a)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("login_admin", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", a.username));
                    cmd.Parameters.Add(new SqlParameter("@password", a.password));
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch
            {
                return 2;
            }
        }

        public List<User> AllUser_Data()
        {
            List<User> data = new List<User>();
            DataTable dt = new DataTable();
            using(SqlConnection con=new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_AllUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach(DataRow row in dt.Rows)
            {
                var details = new User();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.FirstName = row["FirstName"].ToString();
                details.LastName = row["LastName"].ToString();
                details.Username = row["Username"].ToString();
                details.E_Mail = row["E_Mail"].ToString();
                data.Add(details);
            }
           
            return data;
        }

        public List<User> lastweekuser()
        {
            List<User> data = new List<User>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("lastweekuser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new User();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.FirstName = row["FirstName"].ToString();
                details.LastName = row["LastName"].ToString();
                details.Username = row["Username"].ToString();
                details.E_Mail = row["E_Mail"].ToString();
                data.Add(details);
            }

            return data;
        }
        public List<User> UserDetail(int id)
        {
            List<User> data = new List<User>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("User_Details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var details = new User();
                    details.user_id = Convert.ToInt32(sdr["user_id"]);
                    details.profile = sdr["Profile"].ToString();
                    details.FirstName = sdr["FirstName"].ToString();
                    details.LastName = sdr["LastName"].ToString();
                    details.Username = sdr["Username"].ToString();
                    details.E_Mail = sdr["E_Mail"].ToString();
                    details.Date = Convert.ToDateTime(sdr["Date"]);
                    details.Total_followers = Convert.ToInt32(sdr["Total_F"]);
                    details.status = Convert.ToInt32(sdr["status"]);

                    data.Add(details);
                }
            }
            return data;
        }

        public List<User> RemovedUser_Data()
        {
            List<User> data = new List<User>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_RemovedUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new User();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.FirstName = row["FirstName"].ToString();
                details.LastName = row["LastName"].ToString();
                details.Username = row["Username"].ToString();
                details.E_Mail = row["E_Mail"].ToString();
                data.Add(details);
            }

            return data;
        }

        public  void RemoveUser(int id)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Remove_User",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                cmd.ExecuteNonQuery();
            }
        }

        public void unbanUser(int id)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("unban_user", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                cmd.ExecuteNonQuery();
            }
        }

        public List<chart> UserChart()
        {
            List<chart> data = new List<chart>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("User_Chart", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new chart();
                details.Date = Convert.ToDateTime(row["Date"]);
                details.TotalUser = Convert.ToInt32(row["TotalUsers"]);
                details.Total = Convert.ToInt32(row["TotalUser"]);
                details.ActiveUser = Convert.ToInt32(row["ActiveUSer"]);
                data.Add(details);
            }

            return data;
        }
    }
}
