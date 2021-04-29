namespace FinalStaffManager
{
    partial class AttendanceComapererViewerRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fIn = new System.Windows.Forms.Label();
            this.fOut = new System.Windows.Forms.Label();
            this.sIn = new System.Windows.Forms.Label();
            this.sOut = new System.Windows.Forms.Label();
            this.overIn = new System.Windows.Forms.Label();
            this.overOut = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblScode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fIn
            // 
            this.fIn.AutoSize = true;
            this.fIn.Location = new System.Drawing.Point(163, 2);
            this.fIn.Name = "fIn";
            this.fIn.Size = new System.Drawing.Size(35, 13);
            this.fIn.TabIndex = 0;
            this.fIn.Text = "label1";
            // 
            // fOut
            // 
            this.fOut.AutoSize = true;
            this.fOut.Location = new System.Drawing.Point(228, 2);
            this.fOut.Name = "fOut";
            this.fOut.Size = new System.Drawing.Size(35, 13);
            this.fOut.TabIndex = 1;
            this.fOut.Text = "label2";
            // 
            // sIn
            // 
            this.sIn.AutoSize = true;
            this.sIn.Location = new System.Drawing.Point(325, 2);
            this.sIn.Name = "sIn";
            this.sIn.Size = new System.Drawing.Size(35, 13);
            this.sIn.TabIndex = 2;
            this.sIn.Text = "label3";
            // 
            // sOut
            // 
            this.sOut.AutoSize = true;
            this.sOut.Location = new System.Drawing.Point(384, 2);
            this.sOut.Name = "sOut";
            this.sOut.Size = new System.Drawing.Size(35, 13);
            this.sOut.TabIndex = 3;
            this.sOut.Text = "label4";
            // 
            // overIn
            // 
            this.overIn.AutoSize = true;
            this.overIn.Location = new System.Drawing.Point(476, 2);
            this.overIn.Name = "overIn";
            this.overIn.Size = new System.Drawing.Size(35, 13);
            this.overIn.TabIndex = 4;
            this.overIn.Text = "label5";
            // 
            // overOut
            // 
            this.overOut.AutoSize = true;
            this.overOut.Location = new System.Drawing.Point(535, 2);
            this.overOut.Name = "overOut";
            this.overOut.Size = new System.Drawing.Size(35, 13);
            this.overOut.TabIndex = 5;
            this.overOut.Text = "label6";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(79, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(28, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "date";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(5, 2);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "num";
            // 
            // lblScode
            // 
            this.lblScode.AutoSize = true;
            this.lblScode.Location = new System.Drawing.Point(607, 2);
            this.lblScode.Name = "lblScode";
            this.lblScode.Size = new System.Drawing.Size(39, 13);
            this.lblScode.TabIndex = 8;
            this.lblScode.Text = "SCIDE";
            // 
            // AttendanceComapererViewerRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblScode);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.overOut);
            this.Controls.Add(this.overIn);
            this.Controls.Add(this.sOut);
            this.Controls.Add(this.sIn);
            this.Controls.Add(this.fOut);
            this.Controls.Add(this.fIn);
            this.Name = "AttendanceComapererViewerRow";
            this.Size = new System.Drawing.Size(655, 17);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label fIn;
        public System.Windows.Forms.Label fOut;
        public System.Windows.Forms.Label sIn;
        public System.Windows.Forms.Label sOut;
        public System.Windows.Forms.Label overIn;
        public System.Windows.Forms.Label overOut;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblItem;
        public System.Windows.Forms.Label lblScode;
    }
}
