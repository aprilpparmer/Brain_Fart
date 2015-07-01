using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainFart.Model;
using BrainFart.DAL;
using System.Security.Cryptography;
using System.Configuration;


namespace BrainFart.Controller
{
    /// <summary>
    /// Controller class provides user access control for the login form and the entire application.
    /// This class should be a singleton class. Only one instance should be available for the entire application.
    /// Any attempt to create one more should be thwarted because only one user has access to an instance of the application.
    /// http://csharpindepth.com/articles/general/singleton.aspx
    /// Sealed class because we do not want this singleton class to be inherited by some other class and used.
    /// </summary>
    internal sealed class UserAccessController
    {

        private static UserAccessController instance = null;
        private static readonly object padlock = new object();

        private DateTime? loggedInDateTime;
        private Users currentLoggedUser;
       

        public DateTime? LoggedInDateTime { get { return loggedInDateTime; } }
        public Users CurrentLoggedUser { get { return currentLoggedUser; } }

        internal static UserAccessController Instance
        {
            get
            {
                //The lock keyword ensures that one thread does not enter a critical section of code while another thread 
                //is in the critical section. If another thread tries to enter a locked code, it will wait, block, until the object is released.
                //This project is a simple application so it probably runs on only one thread.
                //If there are multiple threads, which is common in enterprise level application, when a second thread enters
                //this piece of code, it will wait till the first thread that entered this code completes. When the initial thread
                //completes its job, an instance of the UserAccessController is already created, so the second thread will
                //exit out when it finds the instance is not null.
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new UserAccessController();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Constructor to User Access Controller class.
        /// </summary>
        internal UserAccessController() { }

        /// <summary>
        /// Logs in a user to the system and assign the logged user and logged in date and time
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        internal bool LoginUser(string username, string password)
        {
            bool UserLoginSuccess = false;
            currentLoggedUser = new Users();
            UserAccessDAL.UserLogin(username, currentLoggedUser);
           
            if (currentLoggedUser.UserPassword == password)
            {
                UserLoginSuccess = true;
                loggedInDateTime = DateTime.Now;
               
            }

            return UserLoginSuccess;
        }

        /// <summary>
        /// Logs out a user. This method simply assigns null to the logged user
        /// logged date and user role objects.
        /// </summary>
        internal void LogOutUser()
        {
            currentLoggedUser = null;
            loggedInDateTime = null;
        }

        internal bool DatabaseExists()
        {
            return UserAccessDAL.databaseExists();
        }

        
        /// <summary>
        /// This method encryptes the user settings information in app.config.
        /// https://msdn.microsoft.com/en-us/library/53tyfkaw%28v=vs.110%29.aspx
        /// </summary>
        internal static void ProtectAndSave()
        {
            try
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                // Get the section.
                ConfigurationSection section = config.GetSection("userSettings/BrainFart.Properties.Settings");

                if (section != null)
                {
                    if (!section.SectionInformation.IsProtected)
                    {
                        if (!section.ElementInformation.IsLocked)
                        {
                            //How to decide what provider to give?
                            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                            section.SectionInformation.ForceSave = true;
                            config.Save(ConfigurationSaveMode.Full);

                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        internal static string ReturnUserSettingsConfig()
        {
            string sectionXml;
            try
            {

                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                ConfigurationSection section = config.GetSection("userSettings/BrainFart.Properties.Settings");
                sectionXml = section.SectionInformation.GetRawXml();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sectionXml;
        }


        internal static void UnprotectUserSettingsConfig()
        {

            try
            {

                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                ConfigurationSection section = config.GetSection("userSettings/BrainFart.Properties.Settings");
                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                    config.Save();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}

