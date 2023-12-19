using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poll4u_Web_BOL
{
    public class Poll
    {
        public int poll_id { get; set; }

        public int Poll_User_id { get; set; }
        public int Admincomment_id { get; set; }
        public int Adminpoll_id { get; set; }
        public int user_id { get; set; }
        public int user_id_f { get; set; }

        public int Transcation_id { get; set; }

        public int Like_id { get; set; }
        public string Profile { get; set; }
        public string username { get; set; }
        public int category_id { get; set; }
        public int Comment_id { get; set; }
        public string category { get; set; }
        public string cp_Question { get; set; }
        public DateTime cp_polldate { get; set; }
        public string cp_visibility { get; set; }
        public int cp_multipleoption { get; set; }
        public int cp_comment { get; set; }

        public string comment { get; set; }
        public string cp_enddate { get; set; }
        public int cp_hideshareoption { get; set; }

        public string cp_share { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public int count1 { get; set; }
        public int count2 { get; set; }
        public int count3 { get; set; }
        public int count4 { get; set; }
        public int Total { get; set; }

        public int TotalCMT { get; set; }
        public int TotalLIKE { get; set; }

        public int TotalVote { get; set; }
    }
}
