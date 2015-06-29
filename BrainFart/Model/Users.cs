using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    class Users
    {

        private string userName;
        private string userPassword;
        private string passwordConfirm;

        public string UserName 
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string UserPassword
        { 
            get
            {
                return userPassword;
            }
            set 
            {
                userPassword = value;
            }
        }


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
