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
    public class Admin_Poll_DAL
    {
        string str = ConfigurationManager.ConnectionStrings["Poll4u_Web"].ConnectionString;
        public List<Poll> AllPolls_Data()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_AllPoll", con);
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
                details.username = row["username"].ToString();
                details.Profile = row["profile"].ToString();
                data.Add(details);
            }
            return data;
        }

        public List<Poll> lastweekpoll_Data()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("lastweekpoll", con);
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
                details.cp_Question = row["cp_question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                data.Add(details);
            }
            return data;
        }
        public List<Poll> ExpireCLose_PollData()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_ExpireCLosePoll", con);
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
                details.username = row["username"].ToString();
                details.Profile = row["profile"].ToString();
                data.Add(details);
            }
            return data;
        }
        public List<Poll> SelectedCategory_Poll(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_SelectedCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@category_id", id));
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
                //details.cp_hideshareoption = Convert.ToInt32(row["cp_hideshareoption"]);
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
        public List<Poll> Poll_Detail(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Poll_Detail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.cp_Question = row["cp_Question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                details.cp_enddate = row["cp_enddate"].ToString();
                details.poll_id = Convert.ToInt32(row["poll_id"]);
                details.option1 = row["option1"].ToString();
                details.option2 = row["option2"].ToString();
                details.option3 = row["option3"].ToString();
                details.option4 = row["option4"].ToString();
                details.count1 = Convert.ToInt32(row["count1"]);
                details.count2 = Convert.ToInt32(row["count2"]);
                details.count3 = Convert.ToInt32(row["count3"]);
                details.count4 = Convert.ToInt32(row["count4"]);
                details.TotalCMT = Convert.ToInt32(row["Totalcmt"]);
                details.TotalLIKE = Convert.ToInt32(row["TotalLike"]);
                details.Total = Convert.ToInt32(row["Total"]);

                data.Add(details);
            }
            return data;
        }
        public void Remove_Poll(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Remove_poll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        public void Unban_Poll(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("unban_poll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        public List<Poll> RemovePoll_Data()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_Removedpoll", con);
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
                details.cp_Question = row["cp_Question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
                data.Add(details);
            }
            return data;
        }
        public List<Category> Get_Category()
        {
            List<Category> data = new List<Category>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_Category", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Category();
                details.category_id = Convert.ToInt32(row["category_id"]);
                details.Name = row["Name"].ToString();
                data.Add(details);
            }
            return data;
        }

        public int Add_Category(string Category)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("add_category", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", Category));
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }

        public void Remove_Category(int id)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Remove_Category", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@category_id", id));
                cmd.ExecuteNonQuery();
            }
        }
        public List<Poll> Get_UserPoll(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("User_PollDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@user_id", id));
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var details = new Poll();
                    details.user_id = Convert.ToInt32(sdr["user_id"]);
                    details.poll_id = Convert.ToInt32(sdr["poll_id"]);
                    details.category_id = Convert.ToInt32(sdr["category_id"]);
                    details.cp_Question = sdr["cp_Question"].ToString();
                    details.cp_polldate = Convert.ToDateTime(sdr["cp_polldate"]);
                    data.Add(details);
                }
            }
            return data;
        }


        public int Admin_CreatePoll(Poll p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("add_AdminPoll", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@category", p.category));
                    cmd.Parameters.Add(new SqlParameter("@cp_question", p.cp_Question));
                    cmd.Parameters.Add(new SqlParameter("@cp_mulptipleoption", p.cp_multipleoption));
                    cmd.Parameters.Add(new SqlParameter("@cp_comment", p.cp_comment));
                    cmd.Parameters.Add(new SqlParameter("@cp_enddate", p.cp_enddate));
                    cmd.Parameters.Add(new SqlParameter("@option1", p.option1));
                    cmd.Parameters.Add(new SqlParameter("@option2", p.option2));
                    cmd.Parameters.Add(new SqlParameter("@option3", p.option3));
                    cmd.Parameters.Add(new SqlParameter("@option4", p.option4));
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

        public List<chart> Pollchart()
        {
            List<chart> data = new List<chart>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Poll_Chart", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new chart();
                details.Date = Convert.ToDateTime(row["Date"]);
                details.TotalPolls = Convert.ToInt32(row["TotalPolls"]);
                details.Total = Convert.ToInt32(row["Total"]);
                details.ActivePoll = Convert.ToInt32(row["ActivePoll"]);

                data.Add(details);
            }

            return data;
        }

        public List<Poll> AdminPoll()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Admin_Polls", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.Adminpoll_id = Convert.ToInt32(row["Adminpoll_id"]);
                details.cp_Question = row["cp_Question"].ToString();
                details.cp_polldate = Convert.ToDateTime(row["cp_polldate"]);
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
                data.Add(details);
            }
            return data;
        }

        public List<Poll> AdminPoll_Comments()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Admin_comment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.Admincomment_id = Convert.ToInt32(row["Admincomment_id"]);
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.Profile = row["profile"].ToString();
                details.Adminpoll_id = Convert.ToInt32(row["Adminpoll_id"]);
                details.comment = row["comment"].ToString();
                details.username = row["username"].ToString();
                data.Add(details);
            }
            return data;
        }

        public List<Poll> AdminPoll_UComments(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_Admincomment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@adminpoll_id", id));
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.Admincomment_id = Convert.ToInt32(row["Admincomment_id"]);
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.Profile = row["profile"].ToString();
                details.Adminpoll_id = Convert.ToInt32(row["Adminpoll_id"]);
                details.comment = row["comment"].ToString();
                details.username = row["username"].ToString();
                data.Add(details);
            }
            return data;
        }
        public int Add_AdminLike(int user_id, int poll_id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Add_AdminLike", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Adminpoll_id", poll_id));
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

        public int Del_AdminComment(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete_Admincomment", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Admincomment_id", id));
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

        public int User_AdminAddComment(int user_id, int poll_id, string cmt)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Add_Admincomment", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Adminpoll_id", poll_id));
                    cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
                    cmd.Parameters.Add(new SqlParameter("@comment", cmt));
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
        public List<Poll> AdminPoll_Like()
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Admin_Like", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.Profile = row["profile"].ToString();
                details.Adminpoll_id = Convert.ToInt32(row["Adminpoll_id"]);
                details.username = row["username"].ToString();
                data.Add(details);
            }
            return data;
        }
        public void Admin_DeletePoll(int id)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Admin_DeletePoll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@adminpoll_id", id));
                cmd.ExecuteNonQuery();
            }
        }

        public List<Poll> Get_PollLike(int id)
        {
            List<Poll> data = new List<Poll>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Get_Like", con);
                cmd.Parameters.Add(new SqlParameter("@poll_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            foreach (DataRow row in dt.Rows)
            {
                var details = new Poll();
                details.user_id = Convert.ToInt32(row["user_id"]);
                details.username = row["username"].ToString();
                details.Like_id = Convert.ToInt32(row["like_id"]);
                details.Profile =row["profile"].ToString();

                data.Add(details);
            }
            return data;
        }
    }
}
