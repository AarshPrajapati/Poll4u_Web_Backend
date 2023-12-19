using Poll4u_Web_BOL;
using Poll4u_Web_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poll4u_Web_BAL
{
    public class User_BAL
    {
        public int User_Login(User u)
        {
            User_DAL Login = new User_DAL();
            return Login.User_Login(u);
        }

        public int Chg_pass(User u)
        {
            User_DAL chp = new User_DAL();
            return chp.Change_Password(u);
        }

        public int In_otp(string email, int otp)
        {
            User_DAL send = new User_DAL();
            return send.insert_otp(email,otp);
        }
        public int rm_otp(User u)
        {
            User_DAL remove = new User_DAL();
            return remove.remove_otp(u);
        }

        public int Ch_otp(string email, int otp)
        {
            User_DAL Check = new User_DAL();
            return Check.Check_otp(email,otp);
        }


        public int User_Signup(User_Signup us)
        {
            User_DAL Signup = new User_DAL();
            return Signup.User_Signup(us);
        }

        public int Check_username(string username)
        {
            User_DAL Check = new User_DAL();
            return Check.Check_Username(username);
        }

        public int edit_username(string username,int id)
        {
            User_DAL Check = new User_DAL();
            return Check.Edit_Username(username,id);
        }

        public int Check_useremail(string email)
        {
            User_DAL Check = new User_DAL();
            return Check.Check_Useremail(email);
        }
        public List<User> GetDataFrom_Username(string Username)
        {
            User_DAL detail = new User_DAL();
            return detail.GetData_FromUsername(Username);
        }

        public List<User> Search_User(string Username)
        {
            User_DAL detail = new User_DAL();
            return detail.Search_User(Username);
        }

        public List<Poll> Get_UserComment(int id)
        {
            User_DAL cmt = new User_DAL();
            return cmt.UserPoll_Comments(id);
        }

        public int User_AddComment(int user_id, int poll_id, string cmt)
        {
            User_DAL addcmt = new User_DAL();
            return addcmt.Add_Usercomment(user_id, poll_id, cmt);
           
        }

        public int Del_Comment(int id)
        {
            User_DAL delcmt = new User_DAL();
            return delcmt.Del_Comment(id);
        }

        public List<Poll> Get_LikeUser(int id)
        {
            User_DAL getlike = new User_DAL();
            return getlike.Get_UserLike(id);
        }

        public int Add_LikeUser(int user_id,int poll_id)
        {
            User_DAL addlike = new User_DAL();
            return addlike.Add_UserLike(user_id, poll_id);
        }

        public int RM_LikeUser(int like_id)
        {
            User_DAL rmlike = new User_DAL();
            return rmlike.rm_UserLike(like_id);
        }

        public List<Poll> UP_userLike(int poll_id)
        {
            User_DAL uplike = new User_DAL();
            return uplike.update_like(poll_id);
        }

        public int Cratepoll_User(Poll p)
        {
            User_DAL cp = new User_DAL();
            return cp.User_CreatePoll(p);
        }
        public int updatepoll_User(Poll p)
        {
            User_DAL cp = new User_DAL();
            return cp.User_UpdatePoll(p);
        }
        public int deletepoll_User(int id)
        {
            User_DAL dp = new User_DAL();
            return dp.User_DeletePoll(id);
        }
        public int Closepoll_User(int id)
        {
            User_DAL cp = new User_DAL();
            return cp.User_ClosePoll(id);
        }
        public List<Poll> Get_PollUser(int id)
        {
            User_DAL getpoll = new User_DAL();
            return getpoll.Get_UserPoll(id);
        }
        public List<Poll> Get_ExpirePollUser(int id)
        {
            User_DAL getpoll = new User_DAL();
            return getpoll.Get_UserExpirePoll(id);
        }
        public List<Poll> Selected_Polldetail(int id)
        {
            User_DAL Polls = new User_DAL();
            return Polls.SelectedPolls_Data(id);
        }

        public int Add_Vote(Poll p)
        {
            User_DAL vote = new User_DAL();
            return vote.Add_vote(p);
        }

        public int Check_Uservote(int u_id, int p_id)
        {
            User_DAL vote = new User_DAL();
            return vote.Check_Uservote(u_id,p_id);
        }

        public List<Poll> UserLiked_Poll(int id)
        {
            User_DAL Liked_Polls = new User_DAL();
            return Liked_Polls.Get_UserLikedPoll(id);
        }

        public int Edit_User(User u)
        {
            User_DAL Edit = new User_DAL();
            return Edit.Edit_User(u);
        }

        public int User_follow(int u_id,int u_id_f)
        {
            User_DAL follow = new User_DAL();
            return follow.Follow(u_id,u_id_f);
        }

        public int User_Unfollow(int u_id, int u_id_f)
        {
            User_DAL unfollow = new User_DAL();
            return unfollow.unfollow(u_id, u_id_f);
        }
        public int Get_UserFollow(int u_id,int u_id_f)
        {
            User_DAL getfollow = new User_DAL();
            return getfollow.Get_UserFollow(u_id,u_id_f);
        }
    }
}
