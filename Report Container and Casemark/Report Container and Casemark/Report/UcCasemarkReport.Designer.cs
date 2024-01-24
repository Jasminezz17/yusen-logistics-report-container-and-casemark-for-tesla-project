namespace Report_Container_and_Casemark.Report
{
    partial class UcCasemarkReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.BtnReprint = new DevExpress.XtraEditors.SimpleButton();
            this.DteEndDate = new DevExpress.XtraEditors.DateEdit();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.LcEndDate = new DevExpress.XtraEditors.LabelControl();
            this.LcStartDate = new DevExpress.XtraEditors.LabelControl();
            this.DteStartDate = new DevExpress.XtraEditors.DateEdit();
            this.LblAppName = new DevExpress.XtraEditors.LabelControl();
            this.GrdcContainer = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdcCasemark = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DteEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DteEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DteStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DteStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdcContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdcCasemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.GrdcContainer);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 120);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.BtnReprint);
            this.panelControl2.Controls.Add(this.DteEndDate);
            this.panelControl2.Controls.Add(this.BtnSearch);
            this.panelControl2.Controls.Add(this.BtnExport);
            this.panelControl2.Controls.Add(this.LcEndDate);
            this.panelControl2.Controls.Add(this.LcStartDate);
            this.panelControl2.Controls.Add(this.DteStartDate);
            this.panelControl2.Controls.Add(this.LblAppName);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(796, 120);
            this.panelControl2.TabIndex = 2;
            // 
            // BtnReprint
            // 
            this.BtnReprint.AllowFocus = false;
            this.BtnReprint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnReprint.ImageOptions.Image = global::Report_Container_and_Casemark.Properties.Resources.Print;
            this.BtnReprint.Location = new System.Drawing.Point(685, 50);
            this.BtnReprint.Name = "BtnReprint";
            this.BtnReprint.Size = new System.Drawing.Size(48, 48);
            this.BtnReprint.TabIndex = 58;
            this.BtnReprint.Click += new System.EventHandler(this.BtnReprint_Click);
            // 
            // DteEndDate
            // 
            this.DteEndDate.EditValue = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DteEndDate.Location = new System.Drawing.Point(397, 68);
            this.DteEndDate.Name = "DteEndDate";
            this.DteEndDate.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DteEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.DteEndDate.Properties.Appearance.Options.UseFont = true;
            this.DteEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.DteEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DteEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DteEndDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.DteEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DteEndDate.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.DteEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DteEndDate.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.DteEndDate.Size = new System.Drawing.Size(193, 28);
            this.DteEndDate.TabIndex = 56;
            this.DteEndDate.EditValueChanged += new System.EventHandler(this.DteEndDate_EditValueChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.AllowFocus = false;
            this.BtnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnSearch.ImageOptions.Image = global::Report_Container_and_Casemark.Properties.Resources.Search_48;
            this.BtnSearch.Location = new System.Drawing.Point(617, 52);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(48, 48);
            this.BtnSearch.TabIndex = 55;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.AllowFocus = false;
            this.BtnExport.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Appearance.Options.UseFont = true;
            this.BtnExport.Appearance.Options.UseTextOptions = true;
            this.BtnExport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.BtnExport.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.BtnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnExport.ImageOptions.Image = global::Report_Container_and_Casemark.Properties.Resources.Microsoft_Excel_48;
            this.BtnExport.Location = new System.Drawing.Point(759, 44);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(57, 58);
            this.BtnExport.TabIndex = 54;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // LcEndDate
            // 
            this.LcEndDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcEndDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.LcEndDate.Appearance.Options.UseFont = true;
            this.LcEndDate.Appearance.Options.UseForeColor = true;
            this.LcEndDate.Location = new System.Drawing.Point(345, 70);
            this.LcEndDate.Name = "LcEndDate";
            this.LcEndDate.Size = new System.Drawing.Size(17, 21);
            this.LcEndDate.TabIndex = 53;
            this.LcEndDate.Text = "To";
            // 
            // LcStartDate
            // 
            this.LcStartDate.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcStartDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.LcStartDate.Appearance.Options.UseFont = true;
            this.LcStartDate.Appearance.Options.UseForeColor = true;
            this.LcStartDate.Location = new System.Drawing.Point(15, 71);
            this.LcStartDate.Name = "LcStartDate";
            this.LcStartDate.Size = new System.Drawing.Size(98, 21);
            this.LcStartDate.TabIndex = 52;
            this.LcStartDate.Text = "Start Date  : ";
            // 
            // DteStartDate
            // 
            this.DteStartDate.EditValue = new System.DateTime(2024, 1, 21, 16, 12, 24, 0);
            this.DteStartDate.Location = new System.Drawing.Point(125, 70);
            this.DteStartDate.Name = "DteStartDate";
            this.DteStartDate.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DteStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.DteStartDate.Properties.Appearance.Options.UseFont = true;
            this.DteStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.DteStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DteStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DteStartDate.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.DteStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DteStartDate.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.DteStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DteStartDate.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.DteStartDate.Size = new System.Drawing.Size(193, 28);
            this.DteStartDate.TabIndex = 51;
            this.DteStartDate.EditValueChanged += new System.EventHandler(this.DteStartDate_EditValueChanged);
            // 
            // LblAppName
            // 
            this.LblAppName.Appearance.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.LblAppName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.LblAppName.Appearance.Options.UseFont = true;
            this.LblAppName.Appearance.Options.UseForeColor = true;
            this.LblAppName.LineVisible = true;
            this.LblAppName.Location = new System.Drawing.Point(15, 19);
            this.LblAppName.Name = "LblAppName";
            this.LblAppName.Size = new System.Drawing.Size(187, 24);
            this.LblAppName.TabIndex = 22;
            this.LblAppName.Text = "Application Name";
            // 
            // GrdcContainer
            // 
            this.GrdcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdcContainer.Location = new System.Drawing.Point(2, 2);
            this.GrdcContainer.MainView = this.gridView2;
            this.GrdcContainer.Name = "GrdcContainer";
            this.GrdcContainer.Size = new System.Drawing.Size(796, 116);
            this.GrdcContainer.TabIndex = 3;
            this.GrdcContainer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GrdcContainer;
            this.gridView2.Name = "gridView2";
            // 
            // GrdcCasemark
            // 
            this.GrdcCasemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdcCasemark.Location = new System.Drawing.Point(0, 120);
            this.GrdcCasemark.MainView = this.gridView1;
            this.GrdcCasemark.Name = "GrdcCasemark";
            this.GrdcCasemark.Size = new System.Drawing.Size(800, 480);
            this.GrdcCasemark.TabIndex = 1;
            this.GrdcCasemark.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.GrdcCasemark;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator_1);
            // 
            // UcCasemarkReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdcCasemark);
            this.Controls.Add(this.panelControl1);
            this.Name = "UcCasemarkReport";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UcCasemarkReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DteEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DteEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DteStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DteStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdcContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdcCasemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit DteEndDate;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.SimpleButton BtnExport;
        private DevExpress.XtraEditors.LabelControl LcEndDate;
        private DevExpress.XtraEditors.LabelControl LcStartDate;
        private DevExpress.XtraEditors.DateEdit DteStartDate;
        private DevExpress.XtraEditors.LabelControl LblAppName;
        private DevExpress.XtraGrid.GridControl GrdcContainer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton BtnReprint;
        private DevExpress.XtraGrid.GridControl GrdcCasemark;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
