using ClosedXML.Excel;
using GUI_SecChecker_v3.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_SecChecker_v3
{
    

    public partial class Form1 : Form
    {
        string timeStamp;
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\Dropbox\Projects\Windows\C#_UB\GUI_SecChecker_v3\GUI_SecChecker_v3\GUI_SecChecker_v3\DataBases\db_SecChecker.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_BrowseADReport_Click(object sender, EventArgs e)
        {
            
            
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
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            tb_PathKESReport.Text = dlg.SelectedPath;
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

        private void bt_GetAllHost_Click(object sender, EventArgs e)
        {
            timeStamp = DateTime.Now.ToString("s").Replace('-', '_').Replace(':', '_');

            string tblADName = tb_TerBank.Text + "_AD_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_AD", "@TableName", tblADName);
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_AD", "@TableName", tblADName, "@FilePath", tb_PathADReport.Text);

            string tblADOmegaName = "OMEGA" + "_AD_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_AD", "@TableName", tblADName);
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_AD", "@TableName", tblADName, "@FilePath", tb_PathADReport.Text);

            string tblKESName = tb_TerBank.Text + "_KES_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_KES", "@TableName", tblKESName);
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_KES", "@TableName", tblKESName, "@FilePath", tb_PathKESReport.Text);

            string tblMPName = tb_TerBank.Text + "_MP_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_MP", "@TableName", tblMPName);
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_MP", "@TableName", tblMPName, "@FilePath", tb_PathMPReport.Text);

            string tblSCCMName = tb_TerBank.Text + "_SCCM_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_SCCM", "@TableName", tblSCCMName);
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_SCCM", "@TableName", tblSCCMName, "@FilePath", tb_PathSCCMReport.Text);

            string tblSEPName = tb_TerBank.Text + "_SEP_" + timeStamp;
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_CreateTable_SEP", "@TableName", tblSEPName);
            SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_Insert_SEP", "@TableName", tblSEPName, "@FilePath", tb_PathSEPReport.Text);



        }

        private void bt_CreateReport_Click(object sender, EventArgs e)
        {
            timeStamp = "2017_03_17T17_27_14";
            //SQL_Executor.Exec_SPU_With_Multple_Parameters_NoReturn(connString, "SPU_SELECT_PROBLEM_HOSTS", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            DataSet ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_ARM_AD_SCCM", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            DataSet ds_ProblemArm_ProblemAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_AVPO", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            DataSet ds_ProblemArm_SUMM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_ARM_SUMM_KES", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            var workbook = new XLWorkbook("report_template_ARM.xlsx");
            var ws1 = workbook.Worksheet(1);

            ws1.Cell("A4").Value = tb_TerBank.Text;
            ws1.Cell("B4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[0].Rows.Count;
            ws1.Cell("D4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[1].Rows.Count;
            ws1.Cell("E4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[2].Rows.Count;
            ws1.Cell("F4").Value = ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[3].Rows.Count;

            ws1.Cell("G4").Value = ds_ProblemArm_ProblemAVPO.Tables[0].Rows.Count;
            ws1.Cell("H4").Value = ds_ProblemArm_ProblemAVPO.Tables[1].Rows.Count;

            ws1.Cell("I4").Value = ds_ProblemArm_SUMM.Tables[0].Rows.Count;

            ws1.Cell("K4").Value = timeStamp;

            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[0].TableName = "All_ARM";
            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[1].TableName = "Without_AD";
            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[2].TableName = "Without_SCCM";
            ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO.Tables[3].TableName = "Without_AVPO";

            workbook.Worksheets.Add(ds_ProblemArm_AllArm_Ad_Sccm_WithoutAVPO);

            ds_ProblemArm_ProblemAVPO.Tables[0].TableName = "KES_Old_Client";
            ds_ProblemArm_ProblemAVPO.Tables[1].TableName = "KES_Old_Base";

            workbook.Worksheets.Add(ds_ProblemArm_ProblemAVPO);

            workbook.SaveAs("ARM_Rep.xlsx");


            DataSet ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_SERV_AD_SCCM", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            DataSet ds_ProblemServ_ProblemAVPO = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_AVPO", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            DataSet ds_ProblemServ_SUMM = SQL_Executor.Exec_SPU_With_Multple_Parameters_Return_DS(connString, "SPU_SELECT_PROBLEM_SERV_SUMM_SEP", "@TerBankName", tb_TerBank.Text, "@TimeStamp", timeStamp);

            var workbook1 = new XLWorkbook("report_template_SERV.xlsx");
            var ws2 = workbook.Worksheet(2);

            ws1.Cell("A4").Value = tb_TerBank.Text;
            ws1.Cell("B4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[0].Rows.Count;
            ws1.Cell("D4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[1].Rows.Count;
            ws1.Cell("E4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[2].Rows.Count;
            ws1.Cell("F4").Value = ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[3].Rows.Count;

            ws1.Cell("G4").Value = ds_ProblemServ_ProblemAVPO.Tables[2].Rows.Count;
            ws1.Cell("H4").Value = ds_ProblemServ_ProblemAVPO.Tables[3].Rows.Count;

            ws1.Cell("I4").Value = ds_ProblemServ_SUMM.Tables[0].Rows.Count;

            ws1.Cell("K4").Value = timeStamp;

            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[0].TableName = "All_SERV";
            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[1].TableName = "Without_AD";
            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[2].TableName = "Without_SCCM";
            ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO.Tables[3].TableName = "Without_AVPO";

            workbook.Worksheets.Add(ds_ProblemServ_AllSERV_Ad_Sccm_WithoutAVPO);

            ds_ProblemServ_ProblemAVPO.Tables[2].TableName = "SEP_Old_Client";
            ds_ProblemServ_ProblemAVPO.Tables[3].TableName = "SEP_Old_Base";

            workbook.Worksheets.Add(ds_ProblemServ_ProblemAVPO);

            workbook.SaveAs("SERV_Rep.xlsx");


        }
    }
}
