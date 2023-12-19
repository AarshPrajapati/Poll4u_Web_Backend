using Poll4u_Web_BOL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poll4u_Web_DAL
{

    //cmd.Executenonquery return the number of row affected.
    public class User_DAL
    {
        string str = ConfigurationManager.ConnectionStrings["Poll4u_Web"].ConnectionString;

        public int User_Login(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Login_User", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", u.Username));
                    cmd.Parameters.Add(new SqlParameter("@password", u.Password));
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

        public int Change_Password(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("change_password", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@email", u.E_Mail));
                    cmd.Parameters.Add(new SqlParameter("@password", u.Password));
                    int i = cmd.ExecuteNonQuery();
                    if (i==1)
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

        public int insert_otp(string email, int otp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert_otp", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@otp", otp));
                    int i= cmd.ExecuteNonQuery();
                    if (i==1)
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
        public int remove_otp(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("rm_otp", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@email",u.E_Mail));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
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
        public int Check_otp(string email, int otp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Check_otp", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@otp", otp));
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

        public int User_CreatePoll(Poll p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("add_UserPoll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@user_id", p.user_id));
                    cmd.Parameters.Add(new SqlParameter("@category_id", p.category_id));
                    cmd.Parameters.Add(new SqlParameter("@cp_question", p.cp_Question));
                    cmd.Parameters.Add(new SqlParameter("@cp_mulptipleoption", p.cp_multipleoption));
                    cmd.Parameters.Add(new SqlParameter("@cp_comment", p.cp_comment));
                    cmd.Parameters.Add(new SqlParameter("@cp_enddate", p.cp_enddate));
                    cmd.Parameters.Add(new SqlParameter("@cp_visibility", p.cp_visibility));
                    cmd.Parameters.Add(new SqlParameter("@option1", p.option1));
                    cmd.Parameters.Add(new SqlParameter("@option2", p.option2));
                    cmd.Parameters.Add(new SqlParameter("@option3", p.option3));
                    cmd.Parameters.Add(new SqlParameter("@option4", p.option4));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch
            {
                return 2;
            }
        }

        public int User_UpdatePoll(Poll p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update_UserPoll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", p.poll_id));
                    cmd.Parameters.Add(new SqlParameter("@category_id", p.category_id));
                    cmd.Parameters.Add(new SqlParameter("@cp_question", p.cp_Question));
                    cmd.Parameters.Add(new SqlParameter("@cp_mulptipleoption", p.cp_multipleoption));
                    cmd.Parameters.Add(new SqlParameter("@cp_comment", p.cp_comment));
                    cmd.Parameters.Add(new SqlParameter("@cp_enddate", p.cp_enddate));
                    cmd.Parameters.Add(new SqlParameter("@cp_visibility", p.cp_visibility));
                    cmd.Parameters.Add(new SqlParameter("@option1", p.option1));
                    cmd.Parameters.Add(new SqlParameter("@option2", p.option2));
                    cmd.Parameters.Add(new SqlParameter("@option3", p.option3));
                    cmd.Parameters.Add(new SqlParameter("@option4", p.option4));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch
            {
                return 2;
            }
        }
        public int User_DeletePoll(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete_Userpoll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id",id));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch
            {
                return 2;
            }
        }
        public int User_ClosePoll(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Close_Userpoll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch
            {
                return 2;
            }
        }
        public int User_Signup(User_Signup us)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("User_Signup", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", us.Username));
                    cmd.Parameters.Add(new SqlParameter("@FirstName", us.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", us.LastName));
                    cmd.Parameters.Add(new SqlParameter("@E_Mail", us.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", us.Password));
                     int i = cmd.ExecuteNonQuery();
                    if (i!=0)
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

        public int Check_Username(string username)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Check_Username", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
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

        public int Edit_Username(string username,int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Check_editusername", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@user_id", id));
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

        public int Check_Useremail(string email)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("check_userEmail", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@email", email));
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
        public List<User> GetData_FromUsername(string Username)
        {
            try
            {
                List<User> data = new List<User>();
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Check_Username", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", Username));
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var details = new User();
                        details.user_id = Convert.ToInt32(row["user_id"]);
                        details.profile = row["profile"].ToString();
                        details.FirstName = row["FirstName"].ToString();
                        details.LastName = row["LastName"].ToString();
                        details.E_Mail = row["E_Mail"].ToString();
                        data.Add(details);
                    }
                    return data;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<User> Search_User(string Username)
        {
            try
            {
                List<User> data = new List<User>();
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("search_User", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", Username));
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var details = new User();
                        details.user_id = Convert.ToInt32(row["user_id"]);
                        details.profile = row["profile"].ToString();
                        details.Username = row["username"].ToString();
                        details.FirstName = row["FirstName"].ToString();
                        details.LastName = row["LastName"].ToString();
                        details.E_Mail = row["E_Mail"].ToString();
                        data.Add(details);
                    }
                    return data;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Poll> UserPoll_Comments(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_Usercomment", con);
                cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.Comment_id = Convert.ToInt32(row["comment_id"]);
                details.Profile = row["profile"].ToString();
                details.poll_id = Convert.ToInt32(row["poll_id"]);
                details.comment = row["comment"].ToString();
                details.username = row["username"].ToString();
                details.Poll_User_id = Convert.ToInt32(row["poll_User_id"]);
                data.Add(details);
            }
            return data;
        }

        public int Add_Usercomment(int user_id,int poll_id,string cmt)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("add_Usercomment", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", poll_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
                    cmd.Parameters.Add(new SqlParameter("@comment", cmt));
                    int i = cmd.ExecuteNonQuery();
                    if (i!=0)
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

        public int Del_Comment(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete_Comment", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@comment_id", id));
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
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

        public List<Poll> Get_UserLike(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_UserLike", con);
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.Like_id = Convert.ToInt32(row["like_id"]);
                details.poll_id = Convert.ToInt32(row["poll_id"]);

                data.Add(details);
            }
            return data;
        }

        public int Add_UserLike(int user_id,int poll_id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("add_Userlike", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", poll_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
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

        public int rm_UserLike(int like_id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("rm_UserLike", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@like_id", like_id));
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
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

        public List<Poll> update_like(int poll_id)
        {
                List<Poll> data = new List<Poll>();
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("update_UserLike", con);
                    cmd.Parameters.Add(new SqlParameter("@poll_id", poll_id));
                    cmd.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                }
                foreach (DataRow row in dt.Rows)
                {
                    var details = new Poll();
                    details.user_id = Convert.ToInt32(row["user_id"]);
                    details.Like_id = Convert.ToInt32(row["like_id"]);
                    details.poll_id = Convert.ToInt32(row["poll_id"]);
                    data.Add(details);
                }
                return data;
        }

        public List<Poll> Get_UserPoll(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_UserPoll", con);
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.poll_id = Convert.ToInt32(row["poll_id"]);
                details.category_id = Convert.ToInt32(row["category_id"]);
                details.category = row["Name"].ToString();
                details.cp_Question = row["cp_question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                details.cp_visibility = row["cp_visibility"].ToString();
                details.cp_multipleoption = Convert.ToInt32(row["cp_mulptipleoption"]);
                details.cp_comment = Convert.ToInt32(row["cp_comment"]);
                details.option1 = row["option1"].ToString();
                details.option2 = row["option2"].ToString();
                details.option3 = row["option3"].ToString();
                details.option4 = row["option4"].ToString();
                details.count1 = Convert.ToInt32(row["count1"]);
                details.count2 = Convert.ToInt32(row["count2"]);
                details.count3 = Convert.ToInt32(row["count3"]);
                details.count4 = Convert.ToInt32(row["count4"]);
                details.Total = Convert.ToInt32(row["Total"]);
                details.TotalCMT = Convert.ToInt32(row["TotalCMT"]);
                details.TotalLIKE = Convert.ToInt32(row["TotalLIKE"]);
                details.TotalVote = Convert.ToInt32(row["TotalVote"]);
                data.Add(details);
            }
            return data;
        }

        public List<Poll> Get_UserExpirePoll(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_UserExpirePoll", con);
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.poll_id = Convert.ToInt32(row["poll_id"]);
                details.category_id = Convert.ToInt32(row["category_id"]);
                details.category = row["Name"].ToString();
                details.cp_Question = row["cp_question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                details.cp_visibility = row["cp_visibility"].ToString();
                details.cp_multipleoption = Convert.ToInt32(row["cp_mulptipleoption"]);
                details.cp_comment = Convert.ToInt32(row["cp_comment"]);
                details.option1 = row["option1"].ToString();
                details.option2 = row["option2"].ToString();
                details.option3 = row["option3"].ToString();
                details.option4 = row["option4"].ToString();
                details.count1 = Convert.ToInt32(row["count1"]);
                details.count2 = Convert.ToInt32(row["count2"]);
                details.count3 = Convert.ToInt32(row["count3"]);
                details.count4 = Convert.ToInt32(row["count4"]);
                details.Total = Convert.ToInt32(row["Total"]);
                details.TotalCMT = Convert.ToInt32(row["TotalCMT"]);
                details.TotalLIKE = Convert.ToInt32(row["TotalLIKE"]);
                details.TotalVote = Convert.ToInt32(row["TotalVote"]);
                data.Add(details);
            }
            return data;
        }

        public List<Poll> Get_UserLikedPoll(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_UserLikePoll", con);
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.username = row["username"].ToString();
                details.Profile = row["profile"].ToString();
                details.poll_id = Convert.ToInt32(row["poll_id"]);
                details.category_id = Convert.ToInt32(row["category_id"]);
                details.category = row["Name"].ToString();
                details.cp_Question = row["cp_question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                details.cp_visibility = row["cp_visibility"].ToString();
                details.cp_multipleoption = Convert.ToInt32(row["cp_mulptipleoption"]);
                details.cp_comment = Convert.ToInt32(row["cp_comment"]);
                details.option1 = row["option1"].ToString();
                details.option2 = row["option2"].ToString();
                details.option3 = row["option3"].ToString();
                details.option4 = row["option4"].ToString();
                details.count1 = Convert.ToInt32(row["count1"]);
                details.count2 = Convert.ToInt32(row["count2"]);
                details.count3 = Convert.ToInt32(row["count3"]);
                details.count4 = Convert.ToInt32(row["count4"]);
                details.Total = Convert.ToInt32(row["Total"]);
                details.TotalCMT = Convert.ToInt32(row["TotalCMT"]);
                details.TotalLIKE = Convert.ToInt32(row["TotalLIKE"]);
             //   details.TotalVote = Convert.ToInt32(row["TotalVote"]);
                data.Add(details);
            }
            return data;
        }
        public List<Poll> SelectedPolls_Data(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("selected_PollDetail", con);
                cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.poll_id = Convert.ToInt32(row["poll_id"]);
                details.category_id = Convert.ToInt32(row["category_id"]);
                details.category = row["Name"].ToString();
                details.cp_Question = row["cp_question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                details.cp_visibility = row["cp_visibility"].ToString();
                details.cp_multipleoption = Convert.ToInt32(row["cp_mulptipleoption"]);
                details.cp_comment = Convert.ToInt32(row["cp_comment"]);
                details.cp_enddate = row["cp_enddate"].ToString();
                details.option1 = row["option1"].ToString();
                details.option2 = row["option2"].ToString();
                details.option3 = row["option3"].ToString();
                details.option4 = row["option4"].ToString();
                details.count1 = Convert.ToInt32(row["count1"]);
                details.count2 = Convert.ToInt32(row["count2"]);
                details.count3 = Convert.ToInt32(row["count3"]);
                details.count4 = Convert.ToInt32(row["count4"]);
                details.Total = Convert.ToInt32(row["Total"]);
                details.TotalCMT = Convert.ToInt32(row["TotalCMT"]);
                details.TotalLIKE = Convert.ToInt32(row["TotalLIKE"]);
                details.username = row["username"].ToString();
                details.Profile = row["profile"].ToString();
                data.Add(details);
            }
            return data;
        }

        public int Add_vote(Poll p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("add_vote", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", p.poll_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id", p.user_id));
                    cmd.Parameters.Add(new SqlParameter("@add1", p.count1));
                    cmd.Parameters.Add(new SqlParameter("@add2", p.count2));
                    cmd.Parameters.Add(new SqlParameter("@add3", p.count3));
                    cmd.Parameters.Add(new SqlParameter("@add4", p.count4));
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
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


        public int Check_Uservote(int u_id,int p_id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Check_Uservote", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", p_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id", u_id));
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        return 3;
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

        public int Edit_User(User u)
        {
            //try
            //{
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Edit_User", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@user_id", u.user_id));
                    if (u.Profile_Action != null)
                    {
                    cmd.Parameters.Add(new SqlParameter("@profile", "/Content/Profile Photo/" + u.profile));
                    }
                cmd.Parameters.Add(new SqlParameter("@username", u.Username));
                    cmd.Parameters.Add(new SqlParameter("@firstname", u.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@lastname", u.LastName));
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            //}
            //catch
            //{
            //    return 2;
            //}
        }

        public int Follow(int u_id,int u_id_f)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("User_follow", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@user_id", u_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id_f", u_id_f));
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
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

        public int unfollow(int u_id, int u_id_f)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("User_unfollow", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@user_id", u_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id_f", u_id_f));
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
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

        public int Get_UserFollow(int u_id,int u_id_f)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("check_Userfollow", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@user_id", u_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id_f", u_id_f));
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
    }
}
