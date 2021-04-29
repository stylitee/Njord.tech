namespace FinalStaffManager
{
    partial class StaffRotationSchedulerMenu
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
            this.schedulePeriodMenu1 = new FinalStaffManager.schedulePeriodMenu();
            this.rcodeMenu1 = new FinalStaffManager.RcodeMenu();
            this.srsScode1 = new FinalStaffManager.SRSScode();
            this.btnSchedPeriod = new System.Windows.Forms.Button();
            this.btnRcodeMenu = new System.Windows.Forms.Button();
            this.btnScodeMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schedulePeriodMenu1
            // 
            this.schedulePeriodMenu1.BackColor = System.Drawing.Color.White;
            this.schedulePeriodMenu1.Location = new System.Drawing.Point(0, 70);
            this.schedulePeriodMenu1.Name = "schedulePeriodMenu1";
            this.schedulePeriodMenu1.Size = new System.Drawing.Size(844, 521);
            this.schedulePeriodMenu1.TabIndex = 6;
            this.schedulePeriodMenu1.Load += new System.EventHandler(this.schedulePeriodMenu1_Load);
            // 
            // rcodeMenu1
            // 
            this.rcodeMenu1.Location = new System.Drawing.Point(-3, 67);
            this.rcodeMenu1.Name = "rcodeMenu1";
            this.rcodeMenu1.Size = new System.Drawing.Size(844, 521);
            this.rcodeMenu1.TabIndex = 5;
            // 
            // srsScode1
            // 
            this.srsScode1.Location = new System.Drawing.Point(0, 67);
            this.srsScode1.Name = "srsScode1";
            this.srsScode1.Size = new System.Drawing.Size(844, 521);
            this.srsScode1.TabIndex = 4;
            // 
            // btnSchedPeriod
            // 
            this.btnSchedPeriod.FlatAppearance.BorderSize = 0;
            this.btnSchedPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedPeriod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedPeriod.Image = global::FinalStaffManager.Properties.Resources.calendar__2_;
            this.btnSchedPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedPeriod.Location = new System.Drawing.Point(566, 18);
            this.btnSchedPeriod.Name = "btnSchedPeriod";
            this.btnSchedPeriod.Size = new System.Drawing.Size(139, 32);
            this.btnSchedPeriod.TabIndex = 2;
            this.btnSchedPeriod.Text = "   Schedule Period";
            this.btnSchedPeriod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedPeriod.UseVisualStyleBackColor = true;
            this.btnSchedPeriod.Click += new System.EventHandler(this.btnSchedPeriod_Click);
            // 
            // btnRcodeMenu
            // 
            this.btnRcodeMenu.FlatAppearance.BorderSize = 0;
            this.btnRcodeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRcodeMenu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRcodeMenu.Image = global::FinalStaffManager.Properties.Resources.transferring;
            this.btnRcodeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRcodeMenu.Location = new System.Drawing.Point(378, 18);
            this.btnRcodeMenu.Name = "btnRcodeMenu";
            this.btnRcodeMenu.Size = new System.Drawing.Size(120, 32);
            this.btnRcodeMenu.TabIndex = 1;
            this.btnRcodeMenu.Text = "  Rcode Menu";
            this.btnRcodeMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRcodeMenu.UseVisualStyleBackColor = true;
            this.btnRcodeMenu.Click += new System.EventHandler(this.btnRcodeMenu_Click);
            // 
            // btnScodeMenu
            // 
            this.btnScodeMenu.FlatAppearance.BorderSize = 0;
            this.btnScodeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScodeMenu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScodeMenu.Image = global::FinalStaffManager.Properties.Resources.schedule;
            this.btnScodeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScodeMenu.Location = new System.Drawing.Point(191, 18);
            this.btnScodeMenu.Name = "btnScodeMenu";
            this.btnScodeMenu.Size = new System.Drawing.Size(122, 32);
            this.btnScodeMenu.TabIndex = 0;
            this.btnScodeMenu.Text = "   Scode Menu";
            this.btnScodeMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScodeMenu.UseVisualStyleBackColor = true;
            this.btnScodeMenu.Click += new System.EventHandler(this.btnScodeMenu_Click);
            // 
            // StaffRotationSchedulerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.schedulePeriodMenu1);
            this.Controls.Add(this.rcodeMenu1);
            this.Controls.Add(this.srsScode1);
            this.Controls.Add(this.btnSchedPeriod);
            this.Controls.Add(this.btnRcodeMenu);
            this.Controls.Add(this.btnScodeMenu);
            this.Name = "StaffRotationSchedulerMenu";
            this.Size = new System.Drawing.Size(844, 591);
            this.Load += new System.EventHandler(this.StaffRotationSchedulerMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScodeMenu;
        private System.Windows.Forms.Button btnRcodeMenu;
        private System.Windows.Forms.Button btnSchedPeriod;
        private SRSScode srsScode1;
        private RcodeMenu rcodeMenu1;
        private schedulePeriodMenu schedulePeriodMenu1;
    }
}
