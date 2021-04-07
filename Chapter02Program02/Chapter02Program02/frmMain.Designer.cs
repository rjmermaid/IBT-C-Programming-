
namespace Chapter02Program02
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtDisplayOutput = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // btnDisplayOutput
            // 
            this.btnDisplayOutput.Location = new System.Drawing.Point(54, 140);
            this.btnDisplayOutput.Name = "btnDisplayOutput";
            this.btnDisplayOutput.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayOutput.TabIndex = 2;
            this.btnDisplayOutput.Text = "&Display";
            this.btnDisplayOutput.UseVisualStyleBackColor = true;
            this.btnDisplayOutput.Click += new System.EventHandler(this.btnDisplayOutput_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(54, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(330, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(437, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Zip";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(404, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(135, 86);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(189, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(376, 84);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(55, 20);
            this.txtState.TabIndex = 9;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(483, 84);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(56, 20);
            this.txtZip.TabIndex = 10;
            // 
            // txtDisplayOutput
            // 
            this.txtDisplayOutput.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayOutput.Location = new System.Drawing.Point(54, 208);
            this.txtDisplayOutput.Multiline = true;
            this.txtDisplayOutput.Name = "txtDisplayOutput";
            this.txtDisplayOutput.ReadOnly = true;
            this.txtDisplayOutput.Size = new System.Drawing.Size(485, 162);
            this.txtDisplayOutput.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(464, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDisplayOutput);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplayOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing Label Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtDisplayOutput;
        private System.Windows.Forms.Button btnExit;
    }
}