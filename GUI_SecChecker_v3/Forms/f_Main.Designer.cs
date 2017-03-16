namespace GUI_SecChecker_v3
{
    partial class Form1
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
            this.bt_TestSQLCon = new System.Windows.Forms.Button();
            this.bt_BrowseSCCMReport = new System.Windows.Forms.Button();
            this.bt_BrowseADReport = new System.Windows.Forms.Button();
            this.bt_BrowseSumReport = new System.Windows.Forms.Button();
            this.bt_BrowseSEPReport = new System.Windows.Forms.Button();
            this.tb_PathSCCMReport = new System.Windows.Forms.TextBox();
            this.bt_BrowseKSCReport = new System.Windows.Forms.Button();
            this.tb_PathADReport = new System.Windows.Forms.TextBox();
            this.tb_PathSumReport = new System.Windows.Forms.TextBox();
            this.tb_PathSEPReport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_PathKSCReport = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_SortArmAndServ = new System.Windows.Forms.Button();
            this.bt_ExportEachResultToExcel = new System.Windows.Forms.Button();
            this.bt_ExportMainResultToExcel = new System.Windows.Forms.Button();
            this.bt_GetAllHost = new System.Windows.Forms.Button();
            this.bt_BrowseMPReport = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_PathMPReport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_TestSQLCon
            // 
            this.bt_TestSQLCon.Location = new System.Drawing.Point(797, 455);
            this.bt_TestSQLCon.Name = "bt_TestSQLCon";
            this.bt_TestSQLCon.Size = new System.Drawing.Size(75, 23);
            this.bt_TestSQLCon.TabIndex = 69;
            this.bt_TestSQLCon.Text = "testSQLCon";
            this.bt_TestSQLCon.UseVisualStyleBackColor = true;
            // 
            // bt_BrowseSCCMReport
            // 
            this.bt_BrowseSCCMReport.Location = new System.Drawing.Point(287, 557);
            this.bt_BrowseSCCMReport.Name = "bt_BrowseSCCMReport";
            this.bt_BrowseSCCMReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseSCCMReport.TabIndex = 51;
            this.bt_BrowseSCCMReport.Text = "Browse";
            this.bt_BrowseSCCMReport.UseVisualStyleBackColor = true;
            this.bt_BrowseSCCMReport.Click += new System.EventHandler(this.bt_BrowseSCCMReport_Click);
            // 
            // bt_BrowseADReport
            // 
            this.bt_BrowseADReport.Location = new System.Drawing.Point(287, 56);
            this.bt_BrowseADReport.Name = "bt_BrowseADReport";
            this.bt_BrowseADReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseADReport.TabIndex = 48;
            this.bt_BrowseADReport.Text = "Browse";
            this.bt_BrowseADReport.UseVisualStyleBackColor = true;
            this.bt_BrowseADReport.Click += new System.EventHandler(this.bt_BrowseADReport_Click_1);
            // 
            // bt_BrowseSumReport
            // 
            this.bt_BrowseSumReport.Location = new System.Drawing.Point(859, 597);
            this.bt_BrowseSumReport.Name = "bt_BrowseSumReport";
            this.bt_BrowseSumReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseSumReport.TabIndex = 49;
            this.bt_BrowseSumReport.Text = "Browse";
            this.bt_BrowseSumReport.UseVisualStyleBackColor = true;
            // 
            // bt_BrowseSEPReport
            // 
            this.bt_BrowseSEPReport.Location = new System.Drawing.Point(287, 422);
            this.bt_BrowseSEPReport.Name = "bt_BrowseSEPReport";
            this.bt_BrowseSEPReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseSEPReport.TabIndex = 55;
            this.bt_BrowseSEPReport.Text = "Browse";
            this.bt_BrowseSEPReport.UseVisualStyleBackColor = true;
            this.bt_BrowseSEPReport.Click += new System.EventHandler(this.bt_BrowseSEPReport_Click);
            // 
            // tb_PathSCCMReport
            // 
            this.tb_PathSCCMReport.Location = new System.Drawing.Point(18, 557);
            this.tb_PathSCCMReport.Name = "tb_PathSCCMReport";
            this.tb_PathSCCMReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathSCCMReport.TabIndex = 46;
            this.tb_PathSCCMReport.Text = "C:\\Users\\KartashevVS\\Desktop\\2016-11-21\\SZB\\SCCM";
            // 
            // bt_BrowseKSCReport
            // 
            this.bt_BrowseKSCReport.Location = new System.Drawing.Point(287, 293);
            this.bt_BrowseKSCReport.Name = "bt_BrowseKSCReport";
            this.bt_BrowseKSCReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseKSCReport.TabIndex = 56;
            this.bt_BrowseKSCReport.Text = "Browse";
            this.bt_BrowseKSCReport.UseVisualStyleBackColor = true;
            this.bt_BrowseKSCReport.Click += new System.EventHandler(this.bt_BrowseKSCReport_Click);
            // 
            // tb_PathADReport
            // 
            this.tb_PathADReport.Location = new System.Drawing.Point(22, 59);
            this.tb_PathADReport.Name = "tb_PathADReport";
            this.tb_PathADReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathADReport.TabIndex = 47;
            this.tb_PathADReport.Text = "C:\\Users\\KartashevVS\\Desktop\\2016-11-21\\SZB\\AD";
            // 
            // tb_PathSumReport
            // 
            this.tb_PathSumReport.Location = new System.Drawing.Point(623, 597);
            this.tb_PathSumReport.Name = "tb_PathSumReport";
            this.tb_PathSumReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathSumReport.TabIndex = 42;
            // 
            // tb_PathSEPReport
            // 
            this.tb_PathSEPReport.Location = new System.Drawing.Point(18, 424);
            this.tb_PathSEPReport.Name = "tb_PathSEPReport";
            this.tb_PathSEPReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathSEPReport.TabIndex = 43;
            this.tb_PathSEPReport.Text = "C:\\Users\\KartashevVS\\Desktop\\2016-11-21\\SZB\\SEP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 521);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Path To SCCM Report";
            // 
            // tb_PathKSCReport
            // 
            this.tb_PathKSCReport.Location = new System.Drawing.Point(22, 295);
            this.tb_PathKSCReport.Name = "tb_PathKSCReport";
            this.tb_PathKSCReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathKSCReport.TabIndex = 45;
            this.tb_PathKSCReport.Text = "C:\\Users\\KartashevVS\\Desktop\\2016-11-21\\SZB\\KES";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(620, 571);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Путь для папки с результатами";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Path To SEP Report";
            // 
            // bt_SortArmAndServ
            // 
            this.bt_SortArmAndServ.Enabled = false;
            this.bt_SortArmAndServ.Location = new System.Drawing.Point(573, 326);
            this.bt_SortArmAndServ.Name = "bt_SortArmAndServ";
            this.bt_SortArmAndServ.Size = new System.Drawing.Size(75, 56);
            this.bt_SortArmAndServ.TabIndex = 54;
            this.bt_SortArmAndServ.Text = "bt_SortArmAndServ";
            this.bt_SortArmAndServ.UseVisualStyleBackColor = true;
            // 
            // bt_ExportEachResultToExcel
            // 
            this.bt_ExportEachResultToExcel.Location = new System.Drawing.Point(573, 225);
            this.bt_ExportEachResultToExcel.Name = "bt_ExportEachResultToExcel";
            this.bt_ExportEachResultToExcel.Size = new System.Drawing.Size(75, 56);
            this.bt_ExportEachResultToExcel.TabIndex = 53;
            this.bt_ExportEachResultToExcel.Text = "bt_ExportEachResultToExcel";
            this.bt_ExportEachResultToExcel.UseVisualStyleBackColor = true;
            // 
            // bt_ExportMainResultToExcel
            // 
            this.bt_ExportMainResultToExcel.Enabled = false;
            this.bt_ExportMainResultToExcel.Location = new System.Drawing.Point(573, 146);
            this.bt_ExportMainResultToExcel.Name = "bt_ExportMainResultToExcel";
            this.bt_ExportMainResultToExcel.Size = new System.Drawing.Size(75, 56);
            this.bt_ExportMainResultToExcel.TabIndex = 52;
            this.bt_ExportMainResultToExcel.Text = "Export Main Result To Excel";
            this.bt_ExportMainResultToExcel.UseVisualStyleBackColor = true;
            // 
            // bt_GetAllHost
            // 
            this.bt_GetAllHost.Location = new System.Drawing.Point(573, 56);
            this.bt_GetAllHost.Name = "bt_GetAllHost";
            this.bt_GetAllHost.Size = new System.Drawing.Size(75, 56);
            this.bt_GetAllHost.TabIndex = 57;
            this.bt_GetAllHost.Text = "1) Get All Host";
            this.bt_GetAllHost.UseVisualStyleBackColor = true;
            this.bt_GetAllHost.Click += new System.EventHandler(this.bt_GetAllHost_Click);
            // 
            // bt_BrowseMPReport
            // 
            this.bt_BrowseMPReport.Location = new System.Drawing.Point(287, 179);
            this.bt_BrowseMPReport.Name = "bt_BrowseMPReport";
            this.bt_BrowseMPReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseMPReport.TabIndex = 50;
            this.bt_BrowseMPReport.Text = "Browse";
            this.bt_BrowseMPReport.UseVisualStyleBackColor = true;
            this.bt_BrowseMPReport.Click += new System.EventHandler(this.bt_BrowseMPReport_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "SCCM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Path To KSC Report";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "SEP";
            // 
            // tb_PathMPReport
            // 
            this.tb_PathMPReport.Location = new System.Drawing.Point(22, 182);
            this.tb_PathMPReport.Name = "tb_PathMPReport";
            this.tb_PathMPReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathMPReport.TabIndex = 44;
            this.tb_PathMPReport.Text = "C:\\Users\\KartashevVS\\Desktop\\2016-11-21\\SZB\\MP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "KSC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Path To MP Report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "MP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "AD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 648);
            this.Controls.Add(this.bt_TestSQLCon);
            this.Controls.Add(this.bt_BrowseSCCMReport);
            this.Controls.Add(this.bt_BrowseADReport);
            this.Controls.Add(this.bt_BrowseSumReport);
            this.Controls.Add(this.bt_BrowseSEPReport);
            this.Controls.Add(this.tb_PathSCCMReport);
            this.Controls.Add(this.bt_BrowseKSCReport);
            this.Controls.Add(this.tb_PathADReport);
            this.Controls.Add(this.tb_PathSumReport);
            this.Controls.Add(this.tb_PathSEPReport);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_PathKSCReport);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bt_SortArmAndServ);
            this.Controls.Add(this.bt_ExportEachResultToExcel);
            this.Controls.Add(this.bt_ExportMainResultToExcel);
            this.Controls.Add(this.bt_GetAllHost);
            this.Controls.Add(this.bt_BrowseMPReport);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_PathMPReport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_TestSQLCon;
        private System.Windows.Forms.Button bt_BrowseSCCMReport;
        private System.Windows.Forms.Button bt_BrowseADReport;
        private System.Windows.Forms.Button bt_BrowseSumReport;
        private System.Windows.Forms.Button bt_BrowseSEPReport;
        private System.Windows.Forms.TextBox tb_PathSCCMReport;
        private System.Windows.Forms.Button bt_BrowseKSCReport;
        private System.Windows.Forms.TextBox tb_PathADReport;
        private System.Windows.Forms.TextBox tb_PathSumReport;
        private System.Windows.Forms.TextBox tb_PathSEPReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_PathKSCReport;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_SortArmAndServ;
        private System.Windows.Forms.Button bt_ExportEachResultToExcel;
        private System.Windows.Forms.Button bt_ExportMainResultToExcel;
        private System.Windows.Forms.Button bt_GetAllHost;
        private System.Windows.Forms.Button bt_BrowseMPReport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_PathMPReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

