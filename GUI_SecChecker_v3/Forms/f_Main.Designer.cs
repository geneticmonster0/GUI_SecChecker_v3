namespace GUI_SecChecker_v3
{
    partial class f_Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_BrowseSumReport = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_PathSumReport = new System.Windows.Forms.TextBox();
            this.bt_CreateReport = new System.Windows.Forms.Button();
            this.bt_GetReport = new System.Windows.Forms.Button();
            this.bt_GetAllHost = new System.Windows.Forms.Button();
            this.chb_isKESOnARM = new System.Windows.Forms.CheckBox();
            this.tb_TerBank = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_BrowseADOmegaReport = new System.Windows.Forms.Button();
            this.tb_PathADOmegaReport = new System.Windows.Forms.TextBox();
            this.bt_BrowseSCCMReport = new System.Windows.Forms.Button();
            this.bt_BrowseADReport = new System.Windows.Forms.Button();
            this.bt_BrowseSEPReport = new System.Windows.Forms.Button();
            this.tb_PathSCCMReport = new System.Windows.Forms.TextBox();
            this.bt_BrowseKESReport = new System.Windows.Forms.Button();
            this.tb_PathADReport = new System.Windows.Forms.TextBox();
            this.tb_PathSEPReport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_PathKESReport = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_BrowseMPReport = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_PathMPReport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Filters = new System.Windows.Forms.DataGridView();
            this.bt_SaveFilters = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_Revisions = new System.Windows.Forms.DataGridView();
            this.bt_LoadRevision = new System.Windows.Forms.Button();
            this.bt_DeleteRevision = new System.Windows.Forms.Button();
            this.bt_Export_Selected_Revision = new System.Windows.Forms.Button();
            this.bt_InnerRevision = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Filters)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Revisions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1204, 814);
            this.tabControl1.TabIndex = 77;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.bt_BrowseSumReport);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.tb_PathSumReport);
            this.tabPage1.Controls.Add(this.bt_CreateReport);
            this.tabPage1.Controls.Add(this.bt_GetReport);
            this.tabPage1.Controls.Add(this.bt_GetAllHost);
            this.tabPage1.Controls.Add(this.chb_isKESOnARM);
            this.tabPage1.Controls.Add(this.tb_TerBank);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.bt_BrowseADOmegaReport);
            this.tabPage1.Controls.Add(this.tb_PathADOmegaReport);
            this.tabPage1.Controls.Add(this.bt_BrowseSCCMReport);
            this.tabPage1.Controls.Add(this.bt_BrowseADReport);
            this.tabPage1.Controls.Add(this.bt_BrowseSEPReport);
            this.tabPage1.Controls.Add(this.tb_PathSCCMReport);
            this.tabPage1.Controls.Add(this.bt_BrowseKESReport);
            this.tabPage1.Controls.Add(this.tb_PathADReport);
            this.tabPage1.Controls.Add(this.tb_PathSEPReport);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.tb_PathKESReport);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.bt_BrowseMPReport);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tb_PathMPReport);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1196, 788);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загрузка данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_BrowseSumReport
            // 
            this.bt_BrowseSumReport.Location = new System.Drawing.Point(259, 643);
            this.bt_BrowseSumReport.Name = "bt_BrowseSumReport";
            this.bt_BrowseSumReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseSumReport.TabIndex = 102;
            this.bt_BrowseSumReport.Text = "Browse";
            this.bt_BrowseSumReport.UseVisualStyleBackColor = true;
            this.bt_BrowseSumReport.Click += new System.EventHandler(this.bt_BrowseSumReport_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(60, 624);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 13);
            this.label19.TabIndex = 100;
            this.label19.Text = "Путь для папки с результатами";
            // 
            // tb_PathSumReport
            // 
            this.tb_PathSumReport.Location = new System.Drawing.Point(19, 643);
            this.tb_PathSumReport.Name = "tb_PathSumReport";
            this.tb_PathSumReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathSumReport.TabIndex = 101;
            // 
            // bt_CreateReport
            // 
            this.bt_CreateReport.Location = new System.Drawing.Point(612, 189);
            this.bt_CreateReport.Name = "bt_CreateReport";
            this.bt_CreateReport.Size = new System.Drawing.Size(75, 76);
            this.bt_CreateReport.TabIndex = 103;
            this.bt_CreateReport.Text = "Подготовить отчет Для текущей выгрузки";
            this.bt_CreateReport.UseVisualStyleBackColor = true;
            this.bt_CreateReport.Visible = false;
            this.bt_CreateReport.Click += new System.EventHandler(this.bt_CreateReport_Click);
            // 
            // bt_GetReport
            // 
            this.bt_GetReport.Location = new System.Drawing.Point(19, 684);
            this.bt_GetReport.Name = "bt_GetReport";
            this.bt_GetReport.Size = new System.Drawing.Size(315, 56);
            this.bt_GetReport.TabIndex = 104;
            this.bt_GetReport.Text = "Получить отчёт";
            this.bt_GetReport.UseVisualStyleBackColor = true;
            this.bt_GetReport.Click += new System.EventHandler(this.bt_GetReport_Click);
            // 
            // bt_GetAllHost
            // 
            this.bt_GetAllHost.Location = new System.Drawing.Point(612, 106);
            this.bt_GetAllHost.Name = "bt_GetAllHost";
            this.bt_GetAllHost.Size = new System.Drawing.Size(75, 56);
            this.bt_GetAllHost.TabIndex = 104;
            this.bt_GetAllHost.Text = "Загрузить CSV в БД";
            this.bt_GetAllHost.UseVisualStyleBackColor = true;
            this.bt_GetAllHost.Visible = false;
            this.bt_GetAllHost.Click += new System.EventHandler(this.bt_GetAllHost_Click);
            // 
            // chb_isKESOnARM
            // 
            this.chb_isKESOnARM.AutoSize = true;
            this.chb_isKESOnARM.Checked = true;
            this.chb_isKESOnARM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_isKESOnARM.Location = new System.Drawing.Point(79, 54);
            this.chb_isKESOnARM.Name = "chb_isKESOnARM";
            this.chb_isKESOnARM.Size = new System.Drawing.Size(149, 17);
            this.chb_isKESOnARM.TabIndex = 99;
            this.chb_isKESOnARM.Text = "KES установлен на АРМ";
            this.chb_isKESOnARM.UseVisualStyleBackColor = true;
            // 
            // tb_TerBank
            // 
            this.tb_TerBank.Location = new System.Drawing.Point(128, 28);
            this.tb_TerBank.Name = "tb_TerBank";
            this.tb_TerBank.Size = new System.Drawing.Size(100, 20);
            this.tb_TerBank.TabIndex = 98;
            this.tb_TerBank.Text = "SZB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Тербанк";
            // 
            // bt_BrowseADOmegaReport
            // 
            this.bt_BrowseADOmegaReport.Location = new System.Drawing.Point(259, 197);
            this.bt_BrowseADOmegaReport.Name = "bt_BrowseADOmegaReport";
            this.bt_BrowseADOmegaReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseADOmegaReport.TabIndex = 96;
            this.bt_BrowseADOmegaReport.Text = "Browse";
            this.bt_BrowseADOmegaReport.UseVisualStyleBackColor = true;
            this.bt_BrowseADOmegaReport.Click += new System.EventHandler(this.bt_BrowseADOmegaReport_Click);
            // 
            // tb_PathADOmegaReport
            // 
            this.tb_PathADOmegaReport.Location = new System.Drawing.Point(19, 197);
            this.tb_PathADOmegaReport.Name = "tb_PathADOmegaReport";
            this.tb_PathADOmegaReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathADOmegaReport.TabIndex = 95;
            this.tb_PathADOmegaReport.Text = "Z:\\Downloads\\2017-04-21\\Data\\OMEGA\\AD";
            // 
            // bt_BrowseSCCMReport
            // 
            this.bt_BrowseSCCMReport.Location = new System.Drawing.Point(259, 569);
            this.bt_BrowseSCCMReport.Name = "bt_BrowseSCCMReport";
            this.bt_BrowseSCCMReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseSCCMReport.TabIndex = 92;
            this.bt_BrowseSCCMReport.Text = "Browse";
            this.bt_BrowseSCCMReport.UseVisualStyleBackColor = true;
            this.bt_BrowseSCCMReport.Click += new System.EventHandler(this.bt_BrowseSCCMReport_Click);
            // 
            // bt_BrowseADReport
            // 
            this.bt_BrowseADReport.Location = new System.Drawing.Point(259, 123);
            this.bt_BrowseADReport.Name = "bt_BrowseADReport";
            this.bt_BrowseADReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseADReport.TabIndex = 90;
            this.bt_BrowseADReport.Text = "Browse";
            this.bt_BrowseADReport.UseVisualStyleBackColor = true;
            this.bt_BrowseADReport.Click += new System.EventHandler(this.bt_BrowseADReport_Click);
            // 
            // bt_BrowseSEPReport
            // 
            this.bt_BrowseSEPReport.Location = new System.Drawing.Point(259, 476);
            this.bt_BrowseSEPReport.Name = "bt_BrowseSEPReport";
            this.bt_BrowseSEPReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseSEPReport.TabIndex = 93;
            this.bt_BrowseSEPReport.Text = "Browse";
            this.bt_BrowseSEPReport.UseVisualStyleBackColor = true;
            this.bt_BrowseSEPReport.Click += new System.EventHandler(this.bt_BrowseSEPReport_Click);
            // 
            // tb_PathSCCMReport
            // 
            this.tb_PathSCCMReport.Location = new System.Drawing.Point(19, 569);
            this.tb_PathSCCMReport.Name = "tb_PathSCCMReport";
            this.tb_PathSCCMReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathSCCMReport.TabIndex = 88;
            this.tb_PathSCCMReport.Text = "Z:\\Downloads\\2017-04-21\\Data\\SRB\\SCCM";
            // 
            // bt_BrowseKESReport
            // 
            this.bt_BrowseKESReport.Location = new System.Drawing.Point(259, 383);
            this.bt_BrowseKESReport.Name = "bt_BrowseKESReport";
            this.bt_BrowseKESReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseKESReport.TabIndex = 94;
            this.bt_BrowseKESReport.Text = "Browse";
            this.bt_BrowseKESReport.UseVisualStyleBackColor = true;
            this.bt_BrowseKESReport.Click += new System.EventHandler(this.bt_BrowseKESReport_Click);
            // 
            // tb_PathADReport
            // 
            this.tb_PathADReport.Location = new System.Drawing.Point(17, 123);
            this.tb_PathADReport.Name = "tb_PathADReport";
            this.tb_PathADReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathADReport.TabIndex = 89;
            this.tb_PathADReport.Text = "Z:\\Downloads\\2017-04-21\\Data\\SZB\\AD";
            // 
            // tb_PathSEPReport
            // 
            this.tb_PathSEPReport.Location = new System.Drawing.Point(19, 476);
            this.tb_PathSEPReport.Name = "tb_PathSEPReport";
            this.tb_PathSEPReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathSEPReport.TabIndex = 85;
            this.tb_PathSEPReport.Text = "Z:\\Downloads\\2017-04-21\\Data\\SZB\\SEP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Path To SCCM Report";
            // 
            // tb_PathKESReport
            // 
            this.tb_PathKESReport.Location = new System.Drawing.Point(19, 383);
            this.tb_PathKESReport.Name = "tb_PathKESReport";
            this.tb_PathKESReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathKESReport.TabIndex = 87;
            this.tb_PathKESReport.Text = "Z:\\Downloads\\2017-04-21\\Data\\SZB\\KES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Путь к папке с отчётами SEP";
            // 
            // bt_BrowseMPReport
            // 
            this.bt_BrowseMPReport.Location = new System.Drawing.Point(259, 290);
            this.bt_BrowseMPReport.Name = "bt_BrowseMPReport";
            this.bt_BrowseMPReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseMPReport.TabIndex = 91;
            this.bt_BrowseMPReport.Text = "Browse";
            this.bt_BrowseMPReport.UseVisualStyleBackColor = true;
            this.bt_BrowseMPReport.Click += new System.EventHandler(this.bt_BrowseMPReport_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(191, 531);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "SCCM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Путь к папке с отчётами KES";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Symantec";
            // 
            // tb_PathMPReport
            // 
            this.tb_PathMPReport.Location = new System.Drawing.Point(19, 290);
            this.tb_PathMPReport.Name = "tb_PathMPReport";
            this.tb_PathMPReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathMPReport.TabIndex = 86;
            this.tb_PathMPReport.Text = "Z:\\Downloads\\2017-04-21\\Data\\SZB\\MP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Kaspersky";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Путь к папке с отчётами AD OMEGA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Путь к папке с отчётами AD ТБ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Путь к папке с отчётами MP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Active Directory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "MaxPatrol";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dgv_Filters);
            this.tabPage2.Controls.Add(this.bt_SaveFilters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1196, 788);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройка фильтров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_Filters
            // 
            this.dgv_Filters.AllowUserToAddRows = false;
            this.dgv_Filters.AllowUserToDeleteRows = false;
            this.dgv_Filters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Filters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Filters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Filters.Location = new System.Drawing.Point(20, 23);
            this.dgv_Filters.Margin = new System.Windows.Forms.Padding(20);
            this.dgv_Filters.Name = "dgv_Filters";
            this.dgv_Filters.Size = new System.Drawing.Size(1100, 251);
            this.dgv_Filters.TabIndex = 78;
            // 
            // bt_SaveFilters
            // 
            this.bt_SaveFilters.Location = new System.Drawing.Point(20, 297);
            this.bt_SaveFilters.Name = "bt_SaveFilters";
            this.bt_SaveFilters.Size = new System.Drawing.Size(75, 56);
            this.bt_SaveFilters.TabIndex = 77;
            this.bt_SaveFilters.Text = "Сохранить изменение фильтров";
            this.bt_SaveFilters.UseVisualStyleBackColor = true;
            this.bt_SaveFilters.Click += new System.EventHandler(this.bt_SaveFilters_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.dgv_Revisions);
            this.tabPage3.Controls.Add(this.bt_LoadRevision);
            this.tabPage3.Controls.Add(this.bt_DeleteRevision);
            this.tabPage3.Controls.Add(this.bt_Export_Selected_Revision);
            this.tabPage3.Controls.Add(this.bt_InnerRevision);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1196, 788);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список проверок";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_Revisions
            // 
            this.dgv_Revisions.AllowUserToAddRows = false;
            this.dgv_Revisions.AllowUserToDeleteRows = false;
            this.dgv_Revisions.AllowUserToOrderColumns = true;
            this.dgv_Revisions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Revisions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Revisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Revisions.Location = new System.Drawing.Point(20, 20);
            this.dgv_Revisions.Margin = new System.Windows.Forms.Padding(20);
            this.dgv_Revisions.Name = "dgv_Revisions";
            this.dgv_Revisions.Size = new System.Drawing.Size(205, 419);
            this.dgv_Revisions.TabIndex = 80;
            // 
            // bt_LoadRevision
            // 
            this.bt_LoadRevision.Location = new System.Drawing.Point(248, 20);
            this.bt_LoadRevision.Name = "bt_LoadRevision";
            this.bt_LoadRevision.Size = new System.Drawing.Size(75, 56);
            this.bt_LoadRevision.TabIndex = 79;
            this.bt_LoadRevision.Text = "Обновить список проверок";
            this.bt_LoadRevision.UseVisualStyleBackColor = true;
            this.bt_LoadRevision.Click += new System.EventHandler(this.bt_LoadRevision_Click);
            // 
            // bt_DeleteRevision
            // 
            this.bt_DeleteRevision.Location = new System.Drawing.Point(248, 206);
            this.bt_DeleteRevision.Name = "bt_DeleteRevision";
            this.bt_DeleteRevision.Size = new System.Drawing.Size(75, 56);
            this.bt_DeleteRevision.TabIndex = 77;
            this.bt_DeleteRevision.Text = "Удалить проверку";
            this.bt_DeleteRevision.UseVisualStyleBackColor = true;
            this.bt_DeleteRevision.Click += new System.EventHandler(this.bt_DeleteRevision_Click);
            // 
            // bt_Export_Selected_Revision
            // 
            this.bt_Export_Selected_Revision.Location = new System.Drawing.Point(248, 144);
            this.bt_Export_Selected_Revision.Name = "bt_Export_Selected_Revision";
            this.bt_Export_Selected_Revision.Size = new System.Drawing.Size(75, 56);
            this.bt_Export_Selected_Revision.TabIndex = 77;
            this.bt_Export_Selected_Revision.Text = "Выгрузить выбранный отчет";
            this.bt_Export_Selected_Revision.UseVisualStyleBackColor = true;
            this.bt_Export_Selected_Revision.Click += new System.EventHandler(this.bt_Export_Selected_Revision_Click);
            // 
            // bt_InnerRevision
            // 
            this.bt_InnerRevision.Location = new System.Drawing.Point(248, 82);
            this.bt_InnerRevision.Name = "bt_InnerRevision";
            this.bt_InnerRevision.Size = new System.Drawing.Size(75, 56);
            this.bt_InnerRevision.TabIndex = 78;
            this.bt_InnerRevision.Text = "Сравнить две проверки";
            this.bt_InnerRevision.UseVisualStyleBackColor = true;
            this.bt_InnerRevision.Click += new System.EventHandler(this.bt_InnerRevision_Click);
            // 
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1204, 814);
            this.Controls.Add(this.tabControl1);
            this.Name = "f_Main";
            this.Text = "SecChecker_v3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Filters)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Revisions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_BrowseSumReport;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_PathSumReport;
        private System.Windows.Forms.Button bt_CreateReport;
        private System.Windows.Forms.Button bt_GetReport;
        private System.Windows.Forms.Button bt_GetAllHost;
        private System.Windows.Forms.CheckBox chb_isKESOnARM;
        private System.Windows.Forms.TextBox tb_TerBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_BrowseADOmegaReport;
        private System.Windows.Forms.TextBox tb_PathADOmegaReport;
        private System.Windows.Forms.Button bt_BrowseSCCMReport;
        private System.Windows.Forms.Button bt_BrowseADReport;
        private System.Windows.Forms.Button bt_BrowseSEPReport;
        private System.Windows.Forms.TextBox tb_PathSCCMReport;
        private System.Windows.Forms.Button bt_BrowseKESReport;
        private System.Windows.Forms.TextBox tb_PathADReport;
        private System.Windows.Forms.TextBox tb_PathSEPReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_PathKESReport;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_BrowseMPReport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_PathMPReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Filters;
        private System.Windows.Forms.Button bt_SaveFilters;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_Revisions;
        private System.Windows.Forms.Button bt_LoadRevision;
        private System.Windows.Forms.Button bt_Export_Selected_Revision;
        private System.Windows.Forms.Button bt_InnerRevision;
        private System.Windows.Forms.Button bt_DeleteRevision;
    }
}

