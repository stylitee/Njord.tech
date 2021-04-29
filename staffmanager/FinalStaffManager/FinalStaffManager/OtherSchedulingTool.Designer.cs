namespace FinalStaffManager
{
    partial class OtherSchedulingTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSchedulePeriod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmployeeList = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Period: ";
            // 
            // cmbSchedulePeriod
            // 
            this.cmbSchedulePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedulePeriod.FormattingEnabled = true;
            this.cmbSchedulePeriod.Location = new System.Drawing.Point(111, 6);
            this.cmbSchedulePeriod.Name = "cmbSchedulePeriod";
            this.cmbSchedulePeriod.Size = new System.Drawing.Size(151, 21);
            this.cmbSchedulePeriod.TabIndex = 1;
            this.cmbSchedulePeriod.TextChanged += new System.EventHandler(this.cmbSchedulePeriod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee: ";
            // 
            // cmbEmployeeList
            // 
            this.cmbEmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeList.FormattingEnabled = true;
            this.cmbEmployeeList.Location = new System.Drawing.Point(455, 6);
            this.cmbEmployeeList.Name = "cmbEmployeeList";
            this.cmbEmployeeList.Size = new System.Drawing.Size(157, 21);
            this.cmbEmployeeList.TabIndex = 3;
            this.cmbEmployeeList.TextChanged += new System.EventHandler(this.cmbEmployeeList_TextChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTable.Location = new System.Drawing.Point(0, 33);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(627, 538);
            this.flpTable.TabIndex = 4;
            // 
            // OtherSchedulingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.cmbEmployeeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSchedulePeriod);
            this.Controls.Add(this.label1);
            this.Name = "OtherSchedulingTool";
            this.Size = new System.Drawing.Size(627, 571);
            this.Load += new System.EventHandler(this.OtherSchedulingTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSchedulePeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmployeeList;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}
