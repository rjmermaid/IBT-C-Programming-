﻿
namespace Chapter14ProgramCreateDatabase.zip
{
    partial class frmCardReport
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
            // frmCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCardReport";
            this.Text = "frmCardReport";
            this.ResumeLayout(false);

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbSent = new System.Windows.Forms.RadioButton();
            this.rbReceived = new System.Windows.Forms.RadioButton();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.rbPerson = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLastName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDate);
            this.groupBox1.Controls.Add(this.rbSent);
            this.groupBox1.Controls.Add(this.rbReceived);
            this.groupBox1.Controls.Add(this.rbType);
            this.groupBox1.Controls.Add(this.rbPerson);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Type:";
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(357, 42);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(48, 17);
            this.rbDate.TabIndex = 5;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Date";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged_1);
            // 
            // rbSent
            // 
            this.rbSent.AutoSize = true;
            this.rbSent.Location = new System.Drawing.Point(186, 42);
            this.rbSent.Name = "rbSent";
            this.rbSent.Size = new System.Drawing.Size(47, 17);
            this.rbSent.TabIndex = 4;
            this.rbSent.TabStop = true;
            this.rbSent.Text = "Sent";
            this.rbSent.UseVisualStyleBackColor = true;
            this.rbSent.CheckedChanged += new System.EventHandler(this.rbSent_CheckedChanged);
            // 
            // rbReceived
            // 
            this.rbReceived.AutoSize = true;
            this.rbReceived.Location = new System.Drawing.Point(6, 42);
            this.rbReceived.Name = "rbReceived";
            this.rbReceived.Size = new System.Drawing.Size(71, 17);
            this.rbReceived.TabIndex = 3;
            this.rbReceived.TabStop = true;
            this.rbReceived.Text = "Received";
            this.rbReceived.UseVisualStyleBackColor = true;
            this.rbReceived.CheckedChanged += new System.EventHandler(this.rbReceived_CheckedChanged);
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.Location = new System.Drawing.Point(357, 19);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(74, 17);
            this.rbType.TabIndex = 2;
            this.rbType.TabStop = true;
            this.rbType.Text = "Card Type";
            this.rbType.UseVisualStyleBackColor = true;
            this.rbType.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Location = new System.Drawing.Point(186, 19);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(58, 17);
            this.rbPerson.TabIndex = 1;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "Person";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbPerson_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(6, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(66, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Cards";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(113, 176);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 20);
            this.txtDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(480, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(480, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbList
            // 
            this.cmbList.Enabled = false;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(113, 152);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(143, 21);
            this.cmbList.TabIndex = 10;
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 14;
            this.lstResult.Location = new System.Drawing.Point(12, 237);
            this.lstResult.Name = "lstResult";
            this.lstResult.ScrollAlwaysVisible = true;
            this.lstResult.Size = new System.Drawing.Size(543, 144);
            this.lstResult.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(163, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Card Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(314, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Sent";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(435, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date Received";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLastName
            // 
            this.cmbLastName.FormattingEnabled = true;
            this.cmbLastName.Location = new System.Drawing.Point(113, 131);
            this.cmbLastName.Name = "cmbLastName";
            this.cmbLastName.Size = new System.Drawing.Size(143, 21);
            this.cmbLastName.TabIndex = 16;
            // 
            // frmCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 433);
            this.Controls.Add(this.cmbLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCardReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cards Exchanged Report";
            this.Load += new System.EventHandler(this.frmCardReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}