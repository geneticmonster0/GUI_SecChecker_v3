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
            this.bt_BrowseADReport = new System.Windows.Forms.Button();
            this.tb_PathADReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_BrowseADReport
            // 
            this.bt_BrowseADReport.Enabled = false;
            this.bt_BrowseADReport.Location = new System.Drawing.Point(274, 64);
            this.bt_BrowseADReport.Name = "bt_BrowseADReport";
            this.bt_BrowseADReport.Size = new System.Drawing.Size(75, 23);
            this.bt_BrowseADReport.TabIndex = 18;
            this.bt_BrowseADReport.Text = "Browse";
            this.bt_BrowseADReport.UseVisualStyleBackColor = true;
            this.bt_BrowseADReport.Click += new System.EventHandler(this.bt_BrowseADReport_Click);
            // 
            // tb_PathADReport
            // 
            this.tb_PathADReport.Enabled = false;
            this.tb_PathADReport.Location = new System.Drawing.Point(38, 66);
            this.tb_PathADReport.Name = "tb_PathADReport";
            this.tb_PathADReport.Size = new System.Drawing.Size(209, 20);
            this.tb_PathADReport.TabIndex = 17;
            this.tb_PathADReport.Text = "C:\\Users\\KartashevVS\\Desktop\\2016-11-21\\SZB\\AD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 545);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_BrowseADReport);
            this.Controls.Add(this.tb_PathADReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_BrowseADReport;
        private System.Windows.Forms.TextBox tb_PathADReport;
        private System.Windows.Forms.Label label6;
    }
}

