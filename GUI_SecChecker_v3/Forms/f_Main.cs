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
            tb_PathKSCReport.Text = dlg.SelectedPath;
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

            SQL_Executor.Exec_SPU_With_Multple_Parameters(connString, "SPU_CreateTable_AD", "@TableName", "AD");
            SQL_Executor.Exec_SPU_With_Multple_Parameters(connString, "SPU_Insert_AD", "@TableName", "AD", "@FilePath", tb_PathADReport.Text);


        }
    }
}
