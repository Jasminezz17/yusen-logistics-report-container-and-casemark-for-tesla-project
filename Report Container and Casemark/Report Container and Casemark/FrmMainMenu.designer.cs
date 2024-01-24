namespace Report_Container_and_Casemark
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.LblAppVersion = new DevExpress.XtraEditors.LabelControl();
            this.LblAppName = new DevExpress.XtraEditors.LabelControl();
            this.accordionControl2 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.AceGroupLogReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AceMenuContainerLog = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AceMenuCasemarkLog = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DmControlPages = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.TabbedView2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DmControlPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabbedView2)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 120);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(200, 475);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "accordionControlElement1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(200, 120);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(925, 475);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(923, 450);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(0, 0);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.BtnSetting);
            this.panelControl1.Controls.Add(this.LblAppVersion);
            this.panelControl1.Controls.Add(this.LblAppName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 101);
            this.panelControl1.TabIndex = 0;
            // 
            // BtnSetting
            // 
            this.BtnSetting.AllowFocus = false;
            this.BtnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnSetting.ImageOptions.Image = global::Report_Container_and_Casemark.Properties.Resources.Settings_2;
            this.BtnSetting.Location = new System.Drawing.Point(705, 13);
            this.BtnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnSetting.Size = new System.Drawing.Size(67, 61);
            this.BtnSetting.TabIndex = 112;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // LblAppVersion
            // 
            this.LblAppVersion.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppVersion.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblAppVersion.Appearance.Options.UseFont = true;
            this.LblAppVersion.Appearance.Options.UseForeColor = true;
            this.LblAppVersion.Location = new System.Drawing.Point(12, 53);
            this.LblAppVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LblAppVersion.Name = "LblAppVersion";
            this.LblAppVersion.Size = new System.Drawing.Size(111, 19);
            this.LblAppVersion.TabIndex = 108;
            this.LblAppVersion.Text = "Version 0.0.0.0";
            // 
            // LblAppName
            // 
            this.LblAppName.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppName.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblAppName.Appearance.Options.UseFont = true;
            this.LblAppName.Appearance.Options.UseForeColor = true;
            this.LblAppName.Location = new System.Drawing.Point(12, 23);
            this.LblAppName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LblAppName.Name = "LblAppName";
            this.LblAppName.Size = new System.Drawing.Size(167, 22);
            this.LblAppName.TabIndex = 107;
            this.LblAppName.Text = "Application Name";
            // 
            // accordionControl2
            // 
            this.accordionControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AceGroupLogReport});
            this.accordionControl2.Location = new System.Drawing.Point(0, 101);
            this.accordionControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.accordionControl2.Name = "accordionControl2";
            this.accordionControl2.Size = new System.Drawing.Size(227, 460);
            this.accordionControl2.TabIndex = 1;
            // 
            // AceGroupLogReport
            // 
            this.AceGroupLogReport.Appearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.AceGroupLogReport.Appearance.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceGroupLogReport.Appearance.Disabled.Options.UseFont = true;
            this.AceGroupLogReport.Appearance.Disabled.Options.UseForeColor = true;
            this.AceGroupLogReport.Appearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.AceGroupLogReport.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceGroupLogReport.Appearance.Hovered.Options.UseFont = true;
            this.AceGroupLogReport.Appearance.Hovered.Options.UseForeColor = true;
            this.AceGroupLogReport.Appearance.Normal.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.AceGroupLogReport.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceGroupLogReport.Appearance.Normal.Options.UseFont = true;
            this.AceGroupLogReport.Appearance.Normal.Options.UseForeColor = true;
            this.AceGroupLogReport.Appearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.AceGroupLogReport.Appearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceGroupLogReport.Appearance.Pressed.Options.UseFont = true;
            this.AceGroupLogReport.Appearance.Pressed.Options.UseForeColor = true;
            this.AceGroupLogReport.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AceMenuContainerLog,
            this.AceMenuCasemarkLog});
            this.AceGroupLogReport.Expanded = true;
            this.AceGroupLogReport.Name = "AceGroupLogReport";
            this.AceGroupLogReport.Text = "Print Report";
            // 
            // AceMenuContainerLog
            // 
            this.AceMenuContainerLog.Appearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceMenuContainerLog.Appearance.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuContainerLog.Appearance.Disabled.Options.UseFont = true;
            this.AceMenuContainerLog.Appearance.Disabled.Options.UseForeColor = true;
            this.AceMenuContainerLog.Appearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuContainerLog.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuContainerLog.Appearance.Hovered.Options.UseFont = true;
            this.AceMenuContainerLog.Appearance.Hovered.Options.UseForeColor = true;
            this.AceMenuContainerLog.Appearance.Normal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuContainerLog.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuContainerLog.Appearance.Normal.Options.UseFont = true;
            this.AceMenuContainerLog.Appearance.Normal.Options.UseForeColor = true;
            this.AceMenuContainerLog.Appearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuContainerLog.Appearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuContainerLog.Appearance.Pressed.Options.UseFont = true;
            this.AceMenuContainerLog.Appearance.Pressed.Options.UseForeColor = true;
            this.AceMenuContainerLog.Name = "AceMenuContainerLog";
            this.AceMenuContainerLog.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AceMenuContainerLog.Text = "Container Log";
            this.AceMenuContainerLog.Click += new System.EventHandler(this.AceMenuContainerLog_Click);
            // 
            // AceMenuCasemarkLog
            // 
            this.AceMenuCasemarkLog.Appearance.Disabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuCasemarkLog.Appearance.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuCasemarkLog.Appearance.Disabled.Options.UseFont = true;
            this.AceMenuCasemarkLog.Appearance.Disabled.Options.UseForeColor = true;
            this.AceMenuCasemarkLog.Appearance.Hovered.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuCasemarkLog.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuCasemarkLog.Appearance.Hovered.Options.UseFont = true;
            this.AceMenuCasemarkLog.Appearance.Hovered.Options.UseForeColor = true;
            this.AceMenuCasemarkLog.Appearance.Normal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuCasemarkLog.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuCasemarkLog.Appearance.Normal.Options.UseFont = true;
            this.AceMenuCasemarkLog.Appearance.Normal.Options.UseForeColor = true;
            this.AceMenuCasemarkLog.Appearance.Pressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AceMenuCasemarkLog.Appearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.AceMenuCasemarkLog.Appearance.Pressed.Options.UseFont = true;
            this.AceMenuCasemarkLog.Appearance.Pressed.Options.UseForeColor = true;
            this.AceMenuCasemarkLog.Name = "AceMenuCasemarkLog";
            this.AceMenuCasemarkLog.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AceMenuCasemarkLog.Text = "Casemark Log";
            this.AceMenuCasemarkLog.Click += new System.EventHandler(this.AceMenuCasemarkLog_Click);
            // 
            // DmControlPages
            // 
            this.DmControlPages.ContainerControl = this;
            this.DmControlPages.View = this.TabbedView2;
            this.DmControlPages.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.TabbedView2});
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.accordionControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DmControlPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabbedView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AceGroupLogReport;
        private DevExpress.XtraBars.Docking2010.DocumentManager DmControlPages;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView TabbedView2;
        private DevExpress.XtraEditors.LabelControl LblAppVersion;
        private DevExpress.XtraEditors.LabelControl LblAppName;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AceMenuContainerLog;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AceMenuCasemarkLog;
        private DevExpress.XtraEditors.SimpleButton BtnSetting;
    }
}