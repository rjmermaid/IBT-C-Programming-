
namespace Chapter13ProgramDirectories.zip
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtStartingPath = new System.Windows.Forms.TextBox();
            this.lblDriveInfo = new System.Windows.Forms.Label();
            this.lstDirectories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting directory:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 39);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(227, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtStartingPath
            // 
            this.txtStartingPath.Location = new System.Drawing.Point(108, 13);
            this.txtStartingPath.Name = "txtStartingPath";
            this.txtStartingPath.Size = new System.Drawing.Size(194, 20);
            this.txtStartingPath.TabIndex = 3;
            // 
            // lblDriveInfo
            // 
            this.lblDriveInfo.AutoSize = true;
            this.lblDriveInfo.Location = new System.Drawing.Point(13, 65);
            this.lblDriveInfo.Name = "lblDriveInfo";
            this.lblDriveInfo.Size = new System.Drawing.Size(35, 13);
            this.lblDriveInfo.TabIndex = 4;
            this.lblDriveInfo.Text = "label2";
            // 
            // lstDirectories
            // 
            this.lstDirectories.FormattingEnabled = true;
            this.lstDirectories.Location = new System.Drawing.Point(12, 90);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(290, 95);
            this.lstDirectories.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 224);
            this.Controls.Add(this.lstDirectories);
            this.Controls.Add(this.lblDriveInfo);
            this.Controls.Add(this.txtStartingPath);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtStartingPath;
        private System.Windows.Forms.Label lblDriveInfo;
        private System.Windows.Forms.ListBox lstDirectories;
    }
}