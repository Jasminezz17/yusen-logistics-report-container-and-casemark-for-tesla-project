using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Report_Container_and_Casemark.Class
{
    class SharedCommon
    {
        #region Variable 

        public const string APPLICATION_NAME = "Report Container and Casemark for Tesla Project";
        public const string CONNECTION_STRING_NAME = "Report_Container_and_Casemark.Properties.Settings.AppConnectionString";

        #endregion


        #region Property 

        public static Version AppVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version;

        public static string AppConnectionString
        {
            get
            {

                if (CONNECTION_STRING_NAME.Length == 0)
                {
                    throw new Exception("Empty connection string!!");
                }

                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME];

                if (settings == null)
                {
                    throw new Exception("Unable to get connection string!!");
                }

                return settings.ConnectionString;
            }

            set
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                ConnectionStringSettings settings = config.ConnectionStrings.ConnectionStrings[CONNECTION_STRING_NAME];

                settings.ConnectionString = value;

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("connectionStrings");

            }
        }
        
        #endregion


        #region Function 
        #endregion


        #region Sub 

        public static void SetCulture(string cultureCode = "en-US")
        {
            CultureInfo cultureInfo;

            try
            {
                cultureInfo = new CultureInfo(cultureCode);
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
                CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
            }
            catch (Exception)
            {
                cultureInfo = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;
            }
        }

         
        #endregion


    }
}
