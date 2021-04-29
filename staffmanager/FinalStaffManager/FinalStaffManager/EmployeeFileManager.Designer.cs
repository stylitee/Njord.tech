namespace FinalStaffManager
{
    partial class EmployeeFileManager
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnListEmployee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.addEmployee1 = new FinalStaffManager.AddEmployee();
            this.addNewEmployee1 = new FinalStaffManager.AddNewEmployee();
            this.updateEmployee1 = new FinalStaffManager.UpdateEmployee();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(331, 3);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(131, 31);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnListEmployee
            // 
            this.btnListEmployee.Location = new System.Drawing.Point(52, 2);
            this.btnListEmployee.Name = "btnListEmployee";
            this.btnListEmployee.Size = new System.Drawing.Size(131, 31);
            this.btnListEmployee.TabIndex = 1;
            this.btnListEmployee.Text = "List of Employee";
            this.btnListEmployee.UseVisualStyleBackColor = true;
            this.btnListEmployee.Click += new System.EventHandler(this.btnListEmployee_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Employee Award";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(603, 460);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(8, 8);
            this.doubleBitmapControl1.TabIndex = 5;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // addEmployee1
            // 
            this.addEmployee1.AutoScroll = true;
            this.addEmployee1.Location = new System.Drawing.Point(10, 42);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(844, 591);
            this.addEmployee1.TabIndex = 4;
            // 
            // addNewEmployee1
            // 
            this.addNewEmployee1.Location = new System.Drawing.Point(10, 42);
            this.addNewEmployee1.Name = "addNewEmployee1";
            this.addNewEmployee1.Size = new System.Drawing.Size(841, 591);
            this.addNewEmployee1.TabIndex = 3;
            // 
            // updateEmployee1
            // 
            this.updateEmployee1.Location = new System.Drawing.Point(7, 42);
            this.updateEmployee1.Name = "updateEmployee1";
            this.updateEmployee1.Size = new System.Drawing.Size(844, 591);
            this.updateEmployee1.TabIndex = 6;
            // 
            // EmployeeFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.addEmployee1);
            this.Controls.Add(this.addNewEmployee1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnListEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.updateEmployee1);
            this.Name = "EmployeeFileManager";
            this.Size = new System.Drawing.Size(861, 648);
            this.Load += new System.EventHandler(this.EmployeeFileManager_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button button3;
        private AddNewEmployee addNewEmployee1;
        private AddEmployee addEmployee1;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        public System.Windows.Forms.Button btnListEmployee;
        private UpdateEmployee updateEmployee1;

    }
}
