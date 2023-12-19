using Poll4u_Web_BOL;
using Poll4u_Web_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poll4u_Web_BAL
{
    public class Admin_Poll_BAL
    {
        public List<Poll> Get_AllPolls()
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.AllPolls_Data();
        }
        public List<Poll> Get_LastWeekPolls()
        {
            Admin_Poll_DAL Poll = new Admin_Poll_DAL();
            return Poll.lastweekpoll_Data();
        }
        public List<Poll> Get_ExpireClosePolls()
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.ExpireCLose_PollData();
        }
        public List<Poll> Select_CategoryPoll(int id)
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.SelectedCategory_Poll(id);
        }
        public List<Poll> Get_PollDetail(int id)
        {
            Admin_Poll_DAL PollDetail = new Admin_Poll_DAL();
            return PollDetail.Poll_Detail(id);
        }

        public List<Poll> Get_UserPoll(int id)
        {
            Admin_Poll_DAL UPoll = new Admin_Poll_DAL();
            return UPoll.Get_UserPoll(id);
        }
        public void RemovePoll(int id)
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            Polls.Remove_Poll(id);
        }

        public List<Poll> Get_RemovdePoll()
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.RemovePoll_Data();
        }

        public void UnbanPoll(int id)
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
             Polls.Unban_Poll(id);
        }

        public List<Category> GetCategory()
        {
            Admin_Poll_DAL category = new Admin_Poll_DAL();
            return category.Get_Category();
        }

        public int AddCategory(string Category)
        {
            Admin_Poll_DAL AddCategory = new Admin_Poll_DAL();
            return AddCategory.Add_Category(Category);
        }

        public void RemoveCategory(int id)
        {
            Admin_Poll_DAL RemoveCategory = new Admin_Poll_DAL();
            RemoveCategory.Remove_Category(id);
        }

        public int AdmincreatePoll(Poll p)
        {
            Admin_Poll_DAL createpoll = new Admin_Poll_DAL();
            return createpoll.Admin_CreatePoll(p);
        }
        public List<chart> PollChart()
        {
            Admin_Poll_DAL Chart = new Admin_Poll_DAL();
            return Chart.Pollchart();
        }

        public List<Poll> Get_AdminPolls()
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.AdminPoll();
        }
        public List<Poll> Get_AdminPollComments()
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.AdminPoll_Comments();
        }

        public List<Poll> Get_AdminPollUComments(int id)
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.AdminPoll_UComments(id);
        }
        public int Add_AdminLikeUser(int user_id,int Adminpoll_id)
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.Add_AdminLike(user_id,Adminpoll_id);
        }

        public int Del_AdminComment(int id)
        {
            Admin_Poll_DAL delcmt = new Admin_Poll_DAL();
            return delcmt.Del_AdminComment(id);
        }

        public int User_AdminAddComment(int user_id,int poll_id,string cmt)
        {
            Admin_Poll_DAL delcmt = new Admin_Poll_DAL();
            return delcmt.User_AdminAddComment(user_id,poll_id, cmt);
        }
        public List<Poll> Get_AdminPollLikes()
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.AdminPoll_Like();
        }
        public void DeleteAdmin_Poll(int id)
        {
            Admin_Poll_DAL Adminpoll = new Admin_Poll_DAL();
            Adminpoll.Admin_DeletePoll(id);
        }

        public List<Poll> Get_UserPollLikes(int id)
        {
            Admin_Poll_DAL Polls = new Admin_Poll_DAL();
            return Polls.Get_PollLike(id);
        }

    }
}
