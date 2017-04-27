using ClosedXML.Excel;
using GUI_SecChecker_v3.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_SecChecker_v3
{
    

    public partial class f_Main : Form
    {
        string timeStamp;
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\Dropbox\Projects\Windows\C#_UB\GUI_SecChecker_v3\GUI_SecChecker_v3\GUI_SecChecker_v3\DataBases\db_SecChecker.mdf;Integrated Security=True";

        private String connectionString = null;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public f_Main()
        {
            InitializeComponent();
        }


        private void bt_GetAllHost_Click(object sender, EventArgs e)
        {
            

        }

        private void UpLoadData()
        {
            timeStamp = DateTime.Now.ToString("s").Replace('-', '_').Replace(':', '_');

            string tblADName = tb_TerBank.Text + "_AD_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_AD", "@TableName", tblADName);

            var dirInfo = new DirectoryInfo(tb_PathADReport.Text);

            foreach (var file in dirInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly))
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_AD", "@TableName", tblADName, "@FilePath", file.FullName);
            }


            dirInfo = new DirectoryInfo(tb_PathADOmegaReport.Text);
            string tblADOmegaName = "OMEGA" + "_AD_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_AD", "@TableName", tblADOmegaName);
            foreach (var file in dirInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly))
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_AD", "@TableName", tblADOmegaName, "@FilePath", file.FullName);
            }

            string tblKESName = tb_TerBank.Text + "_KES_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_KES", "@TableName", tblKESName);
            dirInfo = new DirectoryInfo(tb_PathKESReport.Text);
            foreach (var file in dirInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly))
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_KES", "@TableName", tblKESName, "@FilePath", file.FullName);
            }

            string tblMPName = tb_TerBank.Text + "_MP_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_MP", "@TableName", tblMPName);
            dirInfo = new DirectoryInfo(tb_PathMPReport.Text);
            foreach (var file in dirInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly))
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_MP", "@TableName", tblMPName, "@FilePath", file.FullName);
            }

            string tblSCCMName = tb_TerBank.Text + "_SCCM_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_SCCM", "@TableName", tblSCCMName);
            dirInfo = new DirectoryInfo(tb_PathSCCMReport.Text);
            foreach (var file in dirInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly))
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_SCCM", "@TableName", tblSCCMName, "@FilePath", file.FullName);
            }

            string tblSEPName = tb_TerBank.Text + "_SEP_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_SEP", "@TableName", tblSEPName);
            dirInfo = new DirectoryInfo(tb_PathSEPReport.Text);
            foreach (var file in dirInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly))
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_SEP", "@TableName", tblSEPName, "@FilePath", file.FullName);
            }
        }

        private void bt_CreateReport_Click(object sender, EventArgs e)
        {
            
        }

        private void GetReport(string terBank, string timeStamp, bool isNewRevision = true)
        {
            if (isNewRevision)
            {
                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_INSERT_PROBLEM_HOSTS", "@TerBankName", terBank, "@TimeStamp", timeStamp);
            }


            DataSet ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_ARM_AD_SCCM", "@TerBankName", terBank, "@TimeStamp", timeStamp);

            DataSet ds_ProblemArm_ProblemAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_ARM_AVPO", "@TerBankName", terBank, "@TimeStamp", timeStamp);

            DataSet ds_ProblemArm_SUMM;

            if (chb_isKESOnARM.Checked)
            {
                ds_ProblemArm_SUMM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_ARM_SUMM_KES", "@TerBankName", terBank, "@TimeStamp", timeStamp);
            }
            else
            {
                ds_ProblemArm_SUMM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_ARM_SUMM_SEP", "@TerBankName", terBank, "@TimeStamp", timeStamp);
            }


            var workbook = new XLWorkbook("report_template_ARM.xlsx");
            var ws1 = workbook.Worksheet(1);

            ws1.Cell("A4").Value = terBank;
            ws1.Cell("B4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[0].Rows.Count + ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[1].Rows.Count;
            ws1.Cell("D4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[1].Rows.Count;
            ws1.Cell("E4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[2].Rows.Count;
            ws1.Cell("F4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[3].Rows.Count;
            if (chb_isKESOnARM.Checked)
            {
                ws1.Cell("G4").Value = ds_ProblemArm_ProblemAVPO.Tables[0].Rows.Count;
                ws1.Cell("H4").Value = ds_ProblemArm_ProblemAVPO.Tables[1].Rows.Count;
            }
            else
            {
                ws1.Cell("G4").Value = ds_ProblemArm_ProblemAVPO.Tables[2].Rows.Count;
                ws1.Cell("H4").Value = ds_ProblemArm_ProblemAVPO.Tables[3].Rows.Count;
            }

            ws1.Cell("I4").Value = ds_ProblemArm_SUMM.Tables[0].Rows.Count;

            ws1.Cell("K4").Value = timeStamp;

            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[0].TableName = "All_ARM";
            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[1].TableName = "Without_AD";
            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[2].TableName = "Without_SCCM";
            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[3].TableName = "Without_AVPO";

            workbook.Worksheets.Add(ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO);

            ds_ProblemArm_ProblemAVPO.Tables[0].TableName = "KES_Old_Client";
            ds_ProblemArm_ProblemAVPO.Tables[1].TableName = "KES_Old_Base";
            ds_ProblemArm_ProblemAVPO.Tables[2].TableName = "SEP_Old_Client";
            ds_ProblemArm_ProblemAVPO.Tables[3].TableName = "SEP_Old_Base";

            if (chb_isKESOnARM.Checked)
            {
                workbook.Worksheets.Add(ds_ProblemArm_ProblemAVPO.Tables[0]);
                workbook.Worksheets.Add(ds_ProblemArm_ProblemAVPO.Tables[1]);
            }
            else
            {
                workbook.Worksheets.Add(ds_ProblemArm_ProblemAVPO.Tables[2]);
                workbook.Worksheets.Add(ds_ProblemArm_ProblemAVPO.Tables[3]);
            }


            workbook.SaveAs(tb_PathSumReport.Text + @"\" + terBank + "_ARM_Rep_" + timeStamp + ".xlsx");


            DataSet ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_SERV_AD_SCCM", "@TerBankName", terBank, "@TimeStamp", timeStamp);

            DataSet ds_ProblemServ_ProblemAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_SERV_AVPO", "@TerBankName", terBank, "@TimeStamp", timeStamp);

            DataSet ds_ProblemServ_SUMM;

            if (chb_isKESOnARM.Checked)
            {
                ds_ProblemServ_SUMM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_SERV_SUMM_SEP", "@TerBankName", terBank, "@TimeStamp", timeStamp);
            }
            else
            {
                ds_ProblemServ_SUMM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_SERV_SUMM_KES", "@TerBankName", terBank, "@TimeStamp", timeStamp);
            }

            var workbook1 = new XLWorkbook("report_template_SERV.xlsx");
            var ws2 = workbook1.Worksheet(1);

            ws2.Cell("A4").Value = terBank;
            ws2.Cell("B4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[0].Rows.Count;
            ws2.Cell("D4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[1].Rows.Count;
            ws2.Cell("E4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[2].Rows.Count;
            ws2.Cell("F4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[3].Rows.Count;

            if (chb_isKESOnARM.Checked)
            {
                ws2.Cell("G4").Value = ds_ProblemServ_ProblemAVPO.Tables[2].Rows.Count;
                ws2.Cell("H4").Value = ds_ProblemServ_ProblemAVPO.Tables[3].Rows.Count;
            }
            else
            {
                ws2.Cell("G4").Value = ds_ProblemServ_ProblemAVPO.Tables[0].Rows.Count;
                ws2.Cell("H4").Value = ds_ProblemServ_ProblemAVPO.Tables[1].Rows.Count;
            }

            //Trace.WriteLine($"ws2: {ws2}");

            ws2.Cell("I4").Value = ds_ProblemServ_SUMM.Tables[0].Rows.Count;

            ws2.Cell("K4").Value = timeStamp;

            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[0].TableName = "All_SERV";
            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[1].TableName = "Without_AD";
            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[2].TableName = "Without_SCCM";
            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[3].TableName = "Without_AVPO";

            workbook1.Worksheets.Add(ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO);

            ds_ProblemServ_ProblemAVPO.Tables[0].TableName = "KES_Old_Client";
            ds_ProblemServ_ProblemAVPO.Tables[1].TableName = "KES_Old_Base";
            ds_ProblemServ_ProblemAVPO.Tables[2].TableName = "SEP_Old_Client";
            ds_ProblemServ_ProblemAVPO.Tables[3].TableName = "SEP_Old_Base";

            if (chb_isKESOnARM.Checked)
            {
                workbook1.Worksheets.Add(ds_ProblemServ_ProblemAVPO.Tables[2]);
                workbook1.Worksheets.Add(ds_ProblemServ_ProblemAVPO.Tables[3]);
            }
            else
            {
                workbook1.Worksheets.Add(ds_ProblemServ_ProblemAVPO.Tables[0]);
                workbook1.Worksheets.Add(ds_ProblemServ_ProblemAVPO.Tables[1]);
            }



            workbook1.SaveAs(tb_PathSumReport.Text + @"\" + terBank + "_SERV_Rep_" + timeStamp + ".xlsx");

            
        }

        private void bt_Export_Selected_Revision_Click(object sender, EventArgs e)
        {
            string terBank = dgv_Revisions.SelectedCells[0].Value.ToString();
            string timeStamp = dgv_Revisions.SelectedCells[0].Value.ToString();

            terBank = terBank.Remove(terBank.IndexOf('_'));
            timeStamp = timeStamp.Substring(timeStamp.IndexOf('_') + 1);

            GetReport(terBank, timeStamp, false);
        }

        private void bt_LoadRevision_Click(object sender, EventArgs e)
        {
            dgv_Revisions.DataSource = null;
            dgv_Revisions.DataSource = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_REVISION").Tables[0];
        }

        private void bt_InnerRevision_Click(object sender, EventArgs e)
        {
            string terBank = dgv_Revisions.SelectedCells[0].Value.ToString();
            string timeStamp1 = dgv_Revisions.SelectedCells[0].Value.ToString();
            string timeStamp2 = dgv_Revisions.SelectedCells[1].Value.ToString();

            terBank = terBank.Remove(terBank.IndexOf('_'));
            timeStamp1 = timeStamp1.Substring(timeStamp1.IndexOf('_') + 1);
            timeStamp2 = timeStamp2.Substring(timeStamp2.IndexOf('_') + 1);

            DataSet ds_InnerRevision_ARM_AD_SCCM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_INNER_ARM_REVISION", "@TerBankName", terBank, "@TimeStamp1", timeStamp1, "@TimeStamp2", timeStamp2);
            DataSet ds_InnerRevision_SERV_AD_SCCM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_INNER_SERV_REVISION", "@TerBankName", terBank, "@TimeStamp1", timeStamp1, "@TimeStamp2", timeStamp2);
            DataSet ds_InnerRevision_AVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_INNER_AVPO_REVISION", "@TerBankName", terBank, "@TimeStamp1", timeStamp1, "@TimeStamp2", timeStamp2);


            ds_InnerRevision_ARM_AD_SCCM.Tables[0].TableName = "Without_AD";
            ds_InnerRevision_ARM_AD_SCCM.Tables[1].TableName = "Without_SCCM";
            ds_InnerRevision_ARM_AD_SCCM.Tables[2].TableName = "Without_AVPO";

            ds_InnerRevision_SERV_AD_SCCM.Tables[0].TableName = "Without_AD";
            ds_InnerRevision_SERV_AD_SCCM.Tables[1].TableName = "Without_SCCM";
            ds_InnerRevision_SERV_AD_SCCM.Tables[2].TableName = "Without_AVPO";

            //workbook.Worksheets.Add(ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO);

            ds_InnerRevision_AVPO.Tables[0].TableName = "KES_Old_Client";
            ds_InnerRevision_AVPO.Tables[1].TableName = "KES_Old_Base";
            ds_InnerRevision_AVPO.Tables[2].TableName = "SEP_Old_Client";
            ds_InnerRevision_AVPO.Tables[3].TableName = "SEP_Old_Base";

            var workbook3 = new XLWorkbook();

            workbook3.Worksheets.Add(ds_InnerRevision_ARM_AD_SCCM);
            workbook3.SaveAs(terBank + "_InnerRevision_ARM_" + timeStamp1 + "_" + timeStamp2 + ".xlsx");

            workbook3 = new XLWorkbook();

            workbook3.Worksheets.Add(ds_InnerRevision_SERV_AD_SCCM);
            workbook3.SaveAs(terBank + "_InnerRevision_SERV_" + timeStamp1 + "_" + timeStamp2 + ".xlsx");

            workbook3 = new XLWorkbook();

            workbook3.Worksheets.Add(ds_InnerRevision_AVPO);
            workbook3.SaveAs(terBank + "_InnerRevision_AVPO_" + timeStamp1 + "_" + timeStamp2 + ".xlsx");





        }



        private void bt_BrowseADReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathADReport.Text = dlg.SelectedPath;

        }

        private void bt_BrowseADReport_Click_1(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathADReport.Text = dlg.SelectedPath;
        }

        private void bt_BrowseMPReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathMPReport.Text = dlg.SelectedPath;
        }

        private void bt_BrowseKSCReport_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_BrowseSEPReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathSEPReport.Text = dlg.SelectedPath;
        }

        private void bt_BrowseSCCMReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathSCCMReport.Text = dlg.SelectedPath;
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_SecCheckerDataSet.VARIABLES' table. You can move, or remove it, as needed.
            //this.vARIABLESTableAdapter.Fill(this.db_SecCheckerDataSet.VARIABLES);
            connectionString = connString;
            sqlConnection = new SqlConnection(connectionString);
            selectQueryString = "SELECT * FROM VARIABLES";

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dgv_Filters.DataSource = bindingSource;

        }

        private void bt_SaveFilters_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }

        }

        private void bt_BrowseADOmegaReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathADOmegaReport.Text = dlg.SelectedPath;
        }

        private void bt_BrowseKESReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathKESReport.Text = dlg.SelectedPath;
        }

        private void bt_BrowseSumReport_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathSumReport.Text = dlg.SelectedPath;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            dgv_Revisions.DataSource = null;
            dgv_Revisions.DataSource = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_REVISION").Tables[0];
        }

        private void bt_DeleteRevision_Click(object sender, EventArgs e)
        {            

            for (int i = 0; i < dgv_Revisions.SelectedCells.Count; i++)
            {
                string timeStamp = dgv_Revisions.SelectedCells[i].Value.ToString();

                timeStamp = timeStamp.Substring(timeStamp.IndexOf('_') + 1);

                timeStamp = '%' + timeStamp + '%';

                SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connectionString, "SPU_DELETE_REVISION", "@TimeStamp", timeStamp);
            }
        }

        private void bt_GetReport_Click(object sender, EventArgs e)
        {
            UpLoadData();

            GetReport(tb_TerBank.Text, timeStamp, true);

            MessageBox.Show("REPORTED!");

        }
    }
}
