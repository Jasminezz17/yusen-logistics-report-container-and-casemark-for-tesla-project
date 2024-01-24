using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SATOLib.MessageBox;
using SATOLib.Database.SQL;
using System.Data.SqlClient;
using Report_Container_and_Casemark.Class;

namespace Report_Container_and_Casemark
{
    public partial class FrmSetting : DevExpress.XtraEditors.XtraForm
    {
        #region Variable 
        private bool isLoading = false;
        DbReport dbReport;
        #endregion

        #region DatabaseConnection

        List<string> databaseDataSources;
        List<string> databaseDatabases;
        private string currentSettingDataSource;
        private string currentSettingDatabase;
        private string currentSettingUserId;
        private string currentSettingPassword;
        private int currentSettingConnectTimeOut;

        #endregion

        #region Property 
        #endregion


        #region Function 
        #endregion


        #region Sub 

        private void InitialConnection()
        {
            dbReport = new DbReport(SharedCommon.AppConnectionString);
        }

        private void Database_LoadSettings()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(SharedCommon.AppConnectionString);
            currentSettingDataSource = builder.DataSource;
            currentSettingDatabase = builder.InitialCatalog;
            currentSettingUserId = builder.UserID;
            currentSettingPassword = builder.Password;
            currentSettingConnectTimeOut = builder.ConnectTimeout;
        }

        private void Database_DisplayCurrentSettings()
        {
            CbDatabaseDataSource.Text = currentSettingDataSource;
            CbDatabaseDatabase.Text = currentSettingDatabase;
            TbDatabaseUserId.Text = currentSettingUserId;
            TbDatabasePassword.Text = currentSettingPassword;
            SeDatabaseConnectTimeOut.Value = currentSettingConnectTimeOut;
        }

        private void LoadDatabase()
        {
            isLoading = true;
            if (!BwDatabase_LoadDataSource.IsBusy)
            {
                BwDatabase_LoadDataSource.RunWorkerAsync();
            }
            if (!BwDatabase_LoadDatabase.IsBusy)
            {
                BwDatabase_LoadDatabase.RunWorkerAsync();
            }
            isLoading = false;
        }

        private void SetDefault()
        {
            Database_LoadSettings();
            Database_DisplayCurrentSettings();
            InitialConnection();

            //Load Path Container and Casewmark Label 
            BtnePathLabel.Text = Properties.Settings.Default.PathLabel;

            LblAppName.Text = $"Setting";
        }

        private void GetPathContainerLabel()
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select the directory for label .";
                folderBrowserDialog.ShowNewFolderButton = false;
                folderBrowserDialog.SelectedPath = Application.StartupPath;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    BtnePathLabel.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message.ToString());
            }
        }

        private void SavePathLabelAction()
        {
            try
            {
                if (string.IsNullOrEmpty(BtnePathLabel.Text))
                {
                    Metro.PopUpWarning(this, "Please browse path for label !");
                    return;
                }

                Properties.Settings.Default.PathLabel = BtnePathLabel.Text.Trim();
                Properties.Settings.Default.Save();
                Metro.PopUpInfo(this, "Save data of path label successful .");
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message.ToString());
            }
        }

        private void BackPathLabelAction()
        {
            try
            {
                if (string.IsNullOrEmpty(BtnePathLabel.Text))
                {
                    Metro.PopUpWarning(this, "Please browse path for label !");
                    return;
                }

                Properties.Settings.Default.PathLabel = BtnePathLabel.Text.Trim();
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message.ToString());
            }
        }

        #endregion

        #region Event
        public FrmSetting()
        {
            InitializeComponent();
            SetDefault();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            // Setting Database
            LoadDatabase();
        }

        private void CbDatabaseDataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            if (!BwDatabase_LoadDatabase.IsBusy)
            {
                BwDatabase_LoadDatabase.RunWorkerAsync();
            }
        }

        private void CbDatabaseDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            if (!BwDatabase_LoadDatabase.IsBusy)
            {
                BwDatabase_LoadDatabase.RunWorkerAsync();
            }
        }

        private void BtnDatabaseTestConnection_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = CbDatabaseDataSource.Text;
            builder.InitialCatalog = CbDatabaseDatabase.Text;
            builder.UserID = TbDatabaseUserId.Text;
            builder.Password = TbDatabasePassword.Text;
            builder.ConnectTimeout = (int)SeDatabaseConnectTimeOut.Value;

            try
            {
                SqlDbms dbms = new SqlDbms(builder.ConnectionString);
                if (dbms.IsConnectSuccess())
                {
                    Metro.PopUpInfo(this, "Test connection is successful.");
                }
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message);
            }
        }

        private void BtnDatabaseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDatabaseSave_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = CbDatabaseDataSource.Text;
            builder.InitialCatalog = CbDatabaseDatabase.Text;
            builder.UserID = TbDatabaseUserId.Text;
            builder.Password = TbDatabasePassword.Text;
            builder.ConnectTimeout = (int)SeDatabaseConnectTimeOut.Value;

            SharedCommon.AppConnectionString = builder.ConnectionString;

            Metro.PopUpInfo(this, "Save database settings successful.");
        }

        private void CbDatabaseDataSource_KeyDown(object sender, KeyEventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            if (!BwDatabase_LoadDatabase.IsBusy)
            {
                BwDatabase_LoadDatabase.RunWorkerAsync();
            }
        }

        private void BtnPathLabelBack_Click(object sender, EventArgs e)
        {
            BackPathLabelAction();
        }

        private void BtnPathLabelSave_Click(object sender, EventArgs e)
        {
            SavePathLabelAction();
        }

        private void BtnePathContainerLabel_Click(object sender, EventArgs e)
        {
            GetPathContainerLabel();
        }

        #endregion

    }
}