
namespace Chapter14ProgramCreateDatabase.zip
{
    partial class frmServerSelect
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
            this.SuspendLayout();
            // 
            // frmServerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmServerSelect";
            this.Text = "frmServerSelect";
            this.ResumeLayout(false);

            this.label3 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server to Use:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(130, 17);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(640, 21);
            this.cmbServer.TabIndex = 1;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(130, 120);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(640, 21);
            this.cmbDatabase.TabIndex = 3;
            this.cmbDatabase.Visible = false;
            // 
            // lblDb
            // 
            this.lblDb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDb.Location = new System.Drawing.Point(24, 121);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(100, 20);
            this.lblDb.TabIndex = 2;
            this.lblDb.Text = "Database to Use:";
            this.lblDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDb.Visible = false;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(643, 53);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(127, 23);
            this.btnServer.TabIndex = 5;
            this.btnServer.Text = "&Select Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(643, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmServerSelect
            // 
            this.ClientSize = new System.Drawing.Size(795, 222);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.label3);
            this.Name = "frmServerSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Server and Database";
            this.ResumeLayout(false);
        }

        #endregion
    }
}