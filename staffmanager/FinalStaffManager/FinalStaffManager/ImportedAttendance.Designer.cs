namespace FinalStaffManager
{
    partial class ImportedAttendance
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
            this.lblItem = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txt1stam = new System.Windows.Forms.TextBox();
            this.txt2ndam = new System.Windows.Forms.TextBox();
            this.txt1stpm = new System.Windows.Forms.TextBox();
            this.txt2ndpm = new System.Windows.Forms.TextBox();
            this.txt1stovertime = new System.Windows.Forms.TextBox();
            this.txt2ndovertime = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(12, 6);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "num";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(66, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // txt1stam
            // 
            this.txt1stam.BackColor = System.Drawing.Color.White;
            this.txt1stam.Location = new System.Drawing.Point(163, 3);
            this.txt1stam.Name = "txt1stam";
            this.txt1stam.Size = new System.Drawing.Size(52, 20);
            this.txt1stam.TabIndex = 2;
            this.txt1stam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt1stam_MouseClick);
            this.txt1stam.TextChanged += new System.EventHandler(this.txt1stam_TextChanged_1);
            // 
            // txt2ndam
            // 
            this.txt2ndam.BackColor = System.Drawing.Color.White;
            this.txt2ndam.Location = new System.Drawing.Point(221, 3);
            this.txt2ndam.Name = "txt2ndam";
            this.txt2ndam.Size = new System.Drawing.Size(52, 20);
            this.txt2ndam.TabIndex = 3;
            this.txt2ndam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt2ndam_MouseClick);
            this.txt2ndam.TextChanged += new System.EventHandler(this.txt2ndam_TextChanged);
            // 
            // txt1stpm
            // 
            this.txt1stpm.BackColor = System.Drawing.Color.White;
            this.txt1stpm.Location = new System.Drawing.Point(304, 3);
            this.txt1stpm.Name = "txt1stpm";
            this.txt1stpm.Size = new System.Drawing.Size(52, 20);
            this.txt1stpm.TabIndex = 4;
            this.txt1stpm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt1stpm_MouseClick);
            this.txt1stpm.TextChanged += new System.EventHandler(this.txt1stpm_TextChanged);
            // 
            // txt2ndpm
            // 
            this.txt2ndpm.BackColor = System.Drawing.Color.White;
            this.txt2ndpm.Location = new System.Drawing.Point(362, 3);
            this.txt2ndpm.Name = "txt2ndpm";
            this.txt2ndpm.Size = new System.Drawing.Size(52, 20);
            this.txt2ndpm.TabIndex = 5;
            this.txt2ndpm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt2ndpm_MouseClick);
            this.txt2ndpm.TextChanged += new System.EventHandler(this.txt2ndpm_TextChanged);
            // 
            // txt1stovertime
            // 
            this.txt1stovertime.BackColor = System.Drawing.Color.White;
            this.txt1stovertime.Location = new System.Drawing.Point(442, 3);
            this.txt1stovertime.Name = "txt1stovertime";
            this.txt1stovertime.Size = new System.Drawing.Size(52, 20);
            this.txt1stovertime.TabIndex = 6;
            this.txt1stovertime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt1stovertime_MouseClick);
            this.txt1stovertime.TextChanged += new System.EventHandler(this.txt1stovertime_TextChanged);
            // 
            // txt2ndovertime
            // 
            this.txt2ndovertime.BackColor = System.Drawing.Color.White;
            this.txt2ndovertime.Location = new System.Drawing.Point(500, 3);
            this.txt2ndovertime.Name = "txt2ndovertime";
            this.txt2ndovertime.Size = new System.Drawing.Size(52, 20);
            this.txt2ndovertime.TabIndex = 7;
            this.txt2ndovertime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt2ndovertime_MouseClick);
            this.txt2ndovertime.TextChanged += new System.EventHandler(this.txt2ndovertime_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(717, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 21);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::FinalStaffManager.Properties.Resources.delete__1_;
            this.btnRemove.Location = new System.Drawing.Point(677, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(34, 21);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.Image = global::FinalStaffManager.Properties.Resources.refresh;
            this.btnSwap.Location = new System.Drawing.Point(633, 3);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(38, 21);
            this.btnSwap.TabIndex = 8;
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // ImportedAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.txt2ndovertime);
            this.Controls.Add(this.txt1stovertime);
            this.Controls.Add(this.txt2ndpm);
            this.Controls.Add(this.txt1stpm);
            this.Controls.Add(this.txt2ndam);
            this.Controls.Add(this.txt1stam);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblItem);
            this.Name = "ImportedAttendance";
            this.Size = new System.Drawing.Size(788, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblItem;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.TextBox txt1stam;
        public System.Windows.Forms.TextBox txt2ndam;
        public System.Windows.Forms.TextBox txt1stpm;
        public System.Windows.Forms.TextBox txt2ndpm;
        public System.Windows.Forms.TextBox txt1stovertime;
        public System.Windows.Forms.TextBox txt2ndovertime;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;

    }
}
