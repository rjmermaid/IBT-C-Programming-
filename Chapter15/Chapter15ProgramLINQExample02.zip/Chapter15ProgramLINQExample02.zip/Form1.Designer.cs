﻿
namespace Chapter15ProgramLINQExample02.zip
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lstFull = new System.Windows.Forms.ListBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(143, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(143, 72);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lstFull
            // 
            this.lstFull.FormattingEnabled = true;
            this.lstFull.Location = new System.Drawing.Point(12, 14);
            this.lstFull.Name = "lstFull";
            this.lstFull.Size = new System.Drawing.Size(120, 212);
            this.lstFull.TabIndex = 2;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(229, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 212);
            this.lstOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "State to find:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(143, 30);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(75, 20);
            this.txtState.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 245);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lstFull);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox lstFull;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
    }
}

