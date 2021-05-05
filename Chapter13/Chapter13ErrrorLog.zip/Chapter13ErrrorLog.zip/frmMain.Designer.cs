
namespace Chapter13ErrrorLog.zip
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
            this.rbNumericOverflow = new System.Windows.Forms.RadioButton();
            this.rbFileNotFound = new System.Windows.Forms.RadioButton();
            this.rbDivideBy0 = new System.Windows.Forms.RadioButton();
            this.btnThrow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtErrorMsgs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNumericOverflow
            // 
            this.rbNumericOverflow.AutoSize = true;
            this.rbNumericOverflow.Location = new System.Drawing.Point(0, 19);
            this.rbNumericOverflow.Name = "rbNumericOverflow";
            this.rbNumericOverflow.Size = new System.Drawing.Size(78, 17);
            this.rbNumericOverflow.TabIndex = 0;
            this.rbNumericOverflow.TabStop = true;
            this.rbNumericOverflow.Text = "Divide by 0";
            this.rbNumericOverflow.UseVisualStyleBackColor = true;
            // 
            // rbFileNotFound
            // 
            this.rbFileNotFound.AutoSize = true;
            this.rbFileNotFound.Location = new System.Drawing.Point(90, 19);
            this.rbFileNotFound.Name = "rbFileNotFound";
            this.rbFileNotFound.Size = new System.Drawing.Size(91, 17);
            this.rbFileNotFound.TabIndex = 1;
            this.rbFileNotFound.TabStop = true;
            this.rbFileNotFound.Text = "File Not found";
            this.rbFileNotFound.UseVisualStyleBackColor = true;
            // 
            // rbDivideBy0
            // 
            this.rbDivideBy0.AutoSize = true;
            this.rbDivideBy0.Location = new System.Drawing.Point(181, 19);
            this.rbDivideBy0.Name = "rbDivideBy0";
            this.rbDivideBy0.Size = new System.Drawing.Size(109, 17);
            this.rbDivideBy0.TabIndex = 2;
            this.rbDivideBy0.TabStop = true;
            this.rbDivideBy0.Text = "Numeric Overflow";
            this.rbDivideBy0.UseVisualStyleBackColor = true;
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(305, 14);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(75, 23);
            this.btnThrow.TabIndex = 3;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(305, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtErrorMsgs
            // 
            this.txtErrorMsgs.Location = new System.Drawing.Point(12, 87);
            this.txtErrorMsgs.Multiline = true;
            this.txtErrorMsgs.Name = "txtErrorMsgs";
            this.txtErrorMsgs.Size = new System.Drawing.Size(367, 119);
            this.txtErrorMsgs.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNumericOverflow);
            this.groupBox1.Controls.Add(this.rbFileNotFound);
            this.groupBox1.Controls.Add(this.rbDivideBy0);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 54);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exception";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 221);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtErrorMsgs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThrow);
            this.Name = "frmMain";
            this.Text = "Error Logger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNumericOverflow;
        private System.Windows.Forms.RadioButton rbFileNotFound;
        private System.Windows.Forms.RadioButton rbDivideBy0;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtErrorMsgs;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}