using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Report_Container_and_Casemark.Class;
using System.IO;
using SATOLib.MessageBox;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Office.Crypto;
using SATOPrinterAPI;
using Utils = SATOPrinterAPI.Utils;

namespace Report_Container_and_Casemark.Report
{
    public partial class UcContainerReport : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable 

        DbReport dbReport;
        Printer SATOPrinter = null;
        Driver SATODriver = null;

        #endregion


        #region Property 
        #endregion


        #region Function 

        private Dictionary<string, char> ControlCharList()
        {
            Dictionary<string, char> ctr = new Dictionary<string, char>();
            ctr.Add("[NUL]", '\u0000');
            ctr.Add("[SOH]", '\u0001');
            ctr.Add("[STX]", '\u0002');
            ctr.Add("[ETX]", '\u0003');
            ctr.Add("[EOT]", '\u0004');
            ctr.Add("[ENQ]", '\u0005');
            ctr.Add("[ACK]", '\u0006');
            ctr.Add("[BEL]", '\u0007');
            ctr.Add("[BS]", '\u0008');
            ctr.Add("[HT]", '\u0009');
            ctr.Add("[LF]", '\u000A');
            ctr.Add("[VT]", '\u000B');
            ctr.Add("[FF]", '\u000C');
            ctr.Add("[CR]", '\u000D');
            ctr.Add("[SO]", '\u000E');
            ctr.Add("[SI]", '\u000F');
            ctr.Add("[DLE]", '\u0010');
            ctr.Add("[DC1]", '\u0011');
            ctr.Add("[DC2]", '\u0012');
            ctr.Add("[DC3]", '\u0013');
            ctr.Add("[DC4]", '\u0014');
            ctr.Add("[NAK]", '\u0015');
            ctr.Add("[SYN]", '\u0016');
            ctr.Add("[ETB]", '\u0017');
            ctr.Add("[CAN]", '\u0018');
            ctr.Add("[EM]", '\u0019');
            ctr.Add("[SUB]", '\u001A');
            ctr.Add("[ESC]", '\u001B');
            ctr.Add("[FS]", '\u001C');
            ctr.Add("[GS]", '\u001D');
            ctr.Add("[RS]", '\u001E');
            ctr.Add("[US]", '\u001F');
            ctr.Add("[DEL]", '\u007F');
            return ctr;
        }

        private string ControlCharReplace(string data)
        {
            Dictionary<string, char> chrList = ControlCharList();
            foreach (string key in chrList.Keys)
            {
                data = data.Replace(key, chrList[key].ToString());
            }
            return data;
        }

        #endregion


        #region Sub

        private void InitialConnection()
        {
            dbReport = new DbReport(SharedCommon.AppConnectionString);
        }

        private void SetDefault()
        {
            LblAppName.Text = "Container Log Report";
            InitialConnection();

            gridView1.UserCellPadding = new Padding(5);

            DteStartDate.EditValue = DateTime.Now.Date;
            DteEndDate.EditValue = DateTime.Now.Date;
        }

        private void GetContainerLog()
        {
            try
            {
                DataSet dsActionRequest = null;
                int tableCount = 0;
                bool isComplete = false;
                string responseDescription = string.Empty;

                if (string.IsNullOrEmpty(DteStartDate.EditValue.ToString()))
                {
                    Metro.PopUpWarning(this, "Please select start date !");
                    return;
                }

                if (string.IsNullOrEmpty(DteEndDate.EditValue.ToString()))
                {
                    Metro.PopUpWarning(this, "Please select end date !");
                    return;
                }

                dsActionRequest = dbReport.GetContainerReport(Convert.ToDateTime(DteStartDate.EditValue), Convert.ToDateTime(DteEndDate.EditValue));
                tableCount = (dsActionRequest == null) ? 0 : dsActionRequest.Tables.Count;
                if (tableCount != 2)
                {
                    Metro.PopUpError(this, "Failed to get container log !");
                    return;
                }

                GrdcContainer.DataSource = dsActionRequest.Tables[0];

                DataColumnCollection dataColumn = dsActionRequest.Tables[0].Columns;
                if (dataColumn.Contains("PrintDateTime"))
                {
                    gridView1.Columns["PrintDateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridView1.Columns["PrintDateTime"].DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
                }

                if (dataColumn.Contains("ReprintDateTime"))
                {
                    gridView1.Columns["ReprintDateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridView1.Columns["ReprintDateTime"].DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
                }

                if (dataColumn.Contains("Seq"))
                {
                    gridView1.Columns["Seq"].Visible = false;
                }

                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message);
            }
        }

        private void ExportExcelFile()
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx";
                if (saveFile.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveFile.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            GrdcContainer.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            GrdcContainer.ExportToXlsx(exportFilePath);
                            break;
                        default:
                            break;
                    }
                    if (File.Exists(exportFilePath))
                    {
                        System.Diagnostics.Process.Start(exportFilePath);
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        Metro.PopUpError(this, $"The file could not be saved. {Environment.NewLine}{Environment.NewLine} Path: {exportFilePath}");
                    }
                }

            }
            catch (Exception ex)
            {
                Metro.PopUpError(this, ex.Message);
            }

        }

        private void ReprintAction()
        {
            try
            {
                string pathLabel = Properties.Settings.Default.PathLabel.Trim().ToString();
                if (string.IsNullOrEmpty(pathLabel))
                {
                    Metro.PopUpWarning(this, "Please setting path label !");
                    return;
                }

                SATOPrinter = new Printer();
                SATODriver = new Driver();

                int selectedCount = gridView1.SelectedRowsCount;
                int selectedRowIndex;
                DataRow selectedItemDataRow;

                if (selectedCount == 0)
                {
                    Metro.PopUpWarning(this, "Please select row to reprint!");
                    return;
                }

                selectedRowIndex = gridView1.GetSelectedRows()[0];
                selectedItemDataRow = gridView1.GetDataRow(selectedRowIndex);
                //string aa = selectedItemDataRow[""].ToString();

                string fileFormat = $@"{pathLabel}\ContainerLabel.prn";

                if (!Directory.Exists(pathLabel))
                {
                    Directory.CreateDirectory(pathLabel);
                }

                if (!File.Exists(fileFormat))
                {
                    File.CreateText("");
                }

                string commandSBPL = string.Empty;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Remove(0, stringBuilder.Length);

                using (StreamReader objRead = new StreamReader(fileFormat))
                {
                    stringBuilder.Append(objRead.ReadToEnd());
                }

                commandSBPL = stringBuilder.ToString();

                if (!string.IsNullOrEmpty(commandSBPL))
                {

                    string str = string.Empty;

                    string seq = string.Empty;
                    string printShipment = string.Empty;
                    string printContainerNo = string.Empty;
                    string printPartNo = string.Empty;
                    string printQty = string.Empty;
                    string printerName = string.Empty;
                    string printerIP = string.Empty;
                    int quantityPrint = 1;
                    DateTime printDateTime;
                    DataSet dsActionRequest = null;
                    dsActionRequest = dbReport.GetDateTimeServer();

                    seq = selectedItemDataRow["Seq"].ToString();
                    printShipment = selectedItemDataRow["PrintShipment"].ToString();
                    printContainerNo = selectedItemDataRow["PrintContainerNo"].ToString();
                    printPartNo = selectedItemDataRow["PrintPartNo"].ToString();
                    printQty = selectedItemDataRow["PrintQty"].ToString();
                    printerName = selectedItemDataRow["PrinterName"].ToString();
                    printerIP = selectedItemDataRow["PrinterIP"].ToString();
                    if (dsActionRequest.Tables[0].Rows.Count > 0)
                    {
                        printDateTime = Convert.ToDateTime(dsActionRequest.Tables[0].Rows[0]["ReprintDateTime"]);
                    }
                    else
                    {
                        printDateTime = DateTime.Now;
                    }
                    str = commandSBPL;
                    str = str.Replace("@Containerno", printContainerNo);
                    str = str.Replace("@Shipment", printShipment);
                    str = str.Replace("@PartNo", printPartNo);
                    str = str.Replace("@PrintDatetime", printDateTime.ToString("yyyy-MMM-dd HH:mm:ss"));
                    str = str.Replace("@Qty", printQty);
                    str = str.Replace("@LenQr", printContainerNo.Length.ToString());
                    str = str.Replace("@QuantityPrint", quantityPrint.ToString());
                    if (string.IsNullOrEmpty(printerName))
                    {
                        return;
                    }

                    byte[] cmddata = Utils.StringToByteArray(ControlCharReplace(str));
                    bool printStatus = SATODriver.SendRawData(printerName, cmddata);


                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Event 

        public UcContainerReport()
        {
            InitializeComponent();
            SetDefault();
        }

        private void UcContainerReport_Load(object sender, EventArgs e)
        {
            GetContainerLog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetContainerLog();
        }

        private void BtnReprint_Click(object sender, EventArgs e)
        {
            ReprintAction();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportExcelFile();
        }

        private void DteStartDate_EditValueChanged(object sender, EventArgs e)
        {
            if (DteEndDate.EditValue == null)
            {
                return;
            }
            GetContainerLog();
        }

        private void DteEndDate_EditValueChanged(object sender, EventArgs e)
        {
            if (DteStartDate.EditValue == null)
            {
                return;
            }
            GetContainerLog();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
            {
                return;
            }
            e.Info.DisplayText = $"{e.RowHandle + 1:N0}";
        }

        #endregion


    }
}
