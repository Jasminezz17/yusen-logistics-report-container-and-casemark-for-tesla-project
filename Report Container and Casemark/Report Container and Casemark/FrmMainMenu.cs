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
using Report_Container_and_Casemark.Class;
using Report_Container_and_Casemark.Report;

namespace Report_Container_and_Casemark
{
    public partial class FrmMainMenu : DevExpress.XtraEditors.XtraForm
    {
        #region Variable 
        #endregion 


        #region Property 
        #endregion 


        #region Function 
        #endregion 


        #region Sub 


        private void SettingAction()
        {
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.FormClosed += new FormClosedEventHandler(this.FrmMain_FromClosed);
            frmSetting.Show();
            this.Hide();
        }


        #endregion 


        public FrmMainMenu()
        {
            InitializeComponent();

            this.Text = $"{SharedCommon.APPLICATION_NAME}";
            LblAppName.Text = $"{SharedCommon.APPLICATION_NAME}";
            LblAppVersion.Text = $"Version {SharedCommon.AppVersion.ToString()}";
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                string menuName = "Welcome";

                Control uc = new UcWelcome();
                uc.Text = menuName;

                DmControlPages.View.AddDocument(uc);
                uc.Focus();

                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message);
            }
        }

        private void AceMenuContainerLog_Click(object sender, EventArgs e)
        {
            try
            {
                string menuName = "Container Log";
                foreach (var item in TabbedView2.Documents)
                {
                    if (item.Control.Text == menuName)
                    {
                        item.Control.Focus();
                        return;
                    }
                }

                Control uc = new UcContainerReport();
                uc.Text = menuName;

                DmControlPages.View.AddDocument(uc);
                uc.Focus();
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message);
            }
        }

        private void AceMenuCasemarkLog_Click(object sender, EventArgs e)
        {
            try
            {
                string menuName = "Casemark Log";
                foreach (var item in TabbedView2.Documents)
                {
                    if (item.Control.Text == menuName)
                    {
                        item.Control.Focus();
                        return;
                    }
                }

                Control uc = new UcCasemarkReport();
                uc.Text = menuName;

                DmControlPages.View.AddDocument(uc);
                uc.Focus();
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message);
            }
        }

        private void BarBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SettingAction();
        }

        private void FrmMain_FromClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}