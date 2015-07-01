using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    public class Users
    {
        private int userID;
        //private string userName;
        private string passwordConfirm;


        public int UserID { get { return userID; } set { userID = value; } }

        public string UserName { get; set; }

        public string UserPassword { get; set; }


        public string PasswordConfirm
        {
            get 
            {
                return passwordConfirm;
            }

            set
            {
                passwordConfirm = value;
            }

        }

    }
}
