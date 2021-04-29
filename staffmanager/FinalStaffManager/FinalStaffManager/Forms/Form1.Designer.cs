namespace FinalStaffManager
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStaffRotationScheduler = new System.Windows.Forms.Button();
            this.btnTimeAndAttendance = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.other_Sceduling_Tool1 = new FinalStaffManager.Other_Sceduling_Tool();
            this.staffRotationMenu = new FinalStaffManager.StaffRotationSchedulerMenu();
            this.employeeFileManager1 = new FinalStaffManager.EmployeeFileManager();
            this.timeAndAttendanceCorrector1 = new FinalStaffManager.TimeAndAttendanceCorrector();
            this.home1 = new FinalStaffManager.Home();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnStaffRotationScheduler);
            this.panel1.Controls.Add(this.btnTimeAndAttendance);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 715);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(-7, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 5);
            this.panel4.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "M A I N    M E N U";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::FinalStaffManager.Properties.Resources.seat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(22, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "      Miscellaneous Employee\r\nFile Tools";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FinalStaffManager.Properties.Resources.calendar__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "      Other Scheduling Tool";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStaffRotationScheduler
            // 
            this.btnStaffRotationScheduler.FlatAppearance.BorderSize = 0;
            this.btnStaffRotationScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffRotationScheduler.ForeColor = System.Drawing.Color.White;
            this.btnStaffRotationScheduler.Image = global::FinalStaffManager.Properties.Resources.staff_people_group_in_a_circular_arrow;
            this.btnStaffRotationScheduler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffRotationScheduler.Location = new System.Drawing.Point(22, 406);
            this.btnStaffRotationScheduler.Name = "btnStaffRotationScheduler";
            this.btnStaffRotationScheduler.Size = new System.Drawing.Size(201, 50);
            this.btnStaffRotationScheduler.TabIndex = 20;
            this.btnStaffRotationScheduler.Text = "      Staff Rotation Scheduler";
            this.btnStaffRotationScheduler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffRotationScheduler.UseVisualStyleBackColor = true;
            this.btnStaffRotationScheduler.Click += new System.EventHandler(this.btnStaffRotationScheduler_Click);
            // 
            // btnTimeAndAttendance
            // 
            this.btnTimeAndAttendance.FlatAppearance.BorderSize = 0;
            this.btnTimeAndAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeAndAttendance.ForeColor = System.Drawing.Color.White;
            this.btnTimeAndAttendance.Image = global::FinalStaffManager.Properties.Resources.calendar;
            this.btnTimeAndAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeAndAttendance.Location = new System.Drawing.Point(22, 350);
            this.btnTimeAndAttendance.Name = "btnTimeAndAttendance";
            this.btnTimeAndAttendance.Size = new System.Drawing.Size(201, 50);
            this.btnTimeAndAttendance.TabIndex = 19;
            this.btnTimeAndAttendance.Text = "      Time and Attendance\r\nCorrector";
            this.btnTimeAndAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimeAndAttendance.UseVisualStyleBackColor = true;
            this.btnTimeAndAttendance.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::FinalStaffManager.Properties.Resources.employees;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(22, 294);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(201, 50);
            this.btnEmployee.TabIndex = 18;
            this.btnEmployee.Text = "      Employee File Manager";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::FinalStaffManager.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(22, 238);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 50);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "      Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 140);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalStaffManager.Properties.Resources.admin_settings_male;
            this.pictureBox1.Location = new System.Drawing.Point(47, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(223, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 81);
            this.panel2.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(29, 38);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 16);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(29, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // other_Sceduling_Tool1
            // 
            this.other_Sceduling_Tool1.BackColor = System.Drawing.Color.White;
            this.other_Sceduling_Tool1.Location = new System.Drawing.Point(223, 79);
            this.other_Sceduling_Tool1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.other_Sceduling_Tool1.Name = "other_Sceduling_Tool1";
            this.other_Sceduling_Tool1.Size = new System.Drawing.Size(994, 633);
            this.other_Sceduling_Tool1.TabIndex = 18;
            this.other_Sceduling_Tool1.Load += new System.EventHandler(this.other_Sceduling_Tool1_Load);
            // 
            // staffRotationMenu
            // 
            this.staffRotationMenu.BackColor = System.Drawing.Color.White;
            this.staffRotationMenu.Location = new System.Drawing.Point(223, 79);
            this.staffRotationMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staffRotationMenu.Name = "staffRotationMenu";
            this.staffRotationMenu.Size = new System.Drawing.Size(994, 633);
            this.staffRotationMenu.TabIndex = 17;
            // 
            // employeeFileManager1
            // 
            this.employeeFileManager1.AutoScroll = true;
            this.employeeFileManager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeFileManager1.Location = new System.Drawing.Point(223, 89);
            this.employeeFileManager1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeFileManager1.Name = "employeeFileManager1";
            this.employeeFileManager1.Size = new System.Drawing.Size(994, 622);
            this.employeeFileManager1.TabIndex = 4;
            // 
            // timeAndAttendanceCorrector1
            // 
            this.timeAndAttendanceCorrector1.BackColor = System.Drawing.Color.White;
            this.timeAndAttendanceCorrector1.Location = new System.Drawing.Point(223, 79);
            this.timeAndAttendanceCorrector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeAndAttendanceCorrector1.Name = "timeAndAttendanceCorrector1";
            this.timeAndAttendanceCorrector1.Size = new System.Drawing.Size(994, 636);
            this.timeAndAttendanceCorrector1.TabIndex = 16;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Location = new System.Drawing.Point(223, 89);
            this.home1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(994, 626);
            this.home1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1217, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.other_Sceduling_Tool1);
            this.Controls.Add(this.staffRotationMenu);
            this.Controls.Add(this.employeeFileManager1);
            this.Controls.Add(this.timeAndAttendanceCorrector1);
            this.Controls.Add(this.home1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeFileManager employeeFileManager1;
        private Home home1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTimeAndAttendance;
        private TimeAndAttendanceCorrector timeAndAttendanceCorrector1;
        private System.Windows.Forms.Button btnStaffRotationScheduler;
        private StaffRotationSchedulerMenu staffRotationMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Other_Sceduling_Tool other_Sceduling_Tool1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

