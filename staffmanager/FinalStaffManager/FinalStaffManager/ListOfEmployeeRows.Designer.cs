namespace FinalStaffManager
{
    partial class ListOfEmployeeRows
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirsst = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID NUM";
            // 
            // lblFirsst
            // 
            this.lblFirsst.AutoSize = true;
            this.lblFirsst.Location = new System.Drawing.Point(128, 7);
            this.lblFirsst.Name = "lblFirsst";
            this.lblFirsst.Size = new System.Drawing.Size(36, 13);
            this.lblFirsst.TabIndex = 1;
            this.lblFirsst.Text = "fname";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(238, 7);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(37, 13);
            this.lblMiddle.TabIndex = 2;
            this.lblMiddle.Text = "middle";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(350, 7);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(49, 13);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "lastname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD TO IMPORT FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfEmployeeRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblFirsst);
            this.Controls.Add(this.lblID);
            this.Name = "ListOfEmployeeRows";
            this.Size = new System.Drawing.Size(641, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblFirsst;
        public System.Windows.Forms.Label lblMiddle;
        public System.Windows.Forms.Label lblLast;
    }
}
