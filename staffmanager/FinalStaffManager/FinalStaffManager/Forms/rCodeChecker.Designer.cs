namespace FinalStaffManager.Forms
{
    partial class rCodeChecker
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
            this.flowLayoutRcodeChecker = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutRcodeChecker
            // 
            this.flowLayoutRcodeChecker.AutoScroll = true;
            this.flowLayoutRcodeChecker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutRcodeChecker.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutRcodeChecker.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutRcodeChecker.Name = "flowLayoutRcodeChecker";
            this.flowLayoutRcodeChecker.Size = new System.Drawing.Size(484, 483);
            this.flowLayoutRcodeChecker.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(200, 506);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Back";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 486);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // rCodeChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 541);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.flowLayoutRcodeChecker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rCodeChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rCodeChecker";
            this.Load += new System.EventHandler(this.rCodeChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutRcodeChecker;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblStatus;
    }
}