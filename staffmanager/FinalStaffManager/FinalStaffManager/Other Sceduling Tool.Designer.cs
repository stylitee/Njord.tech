namespace FinalStaffManager
{
    partial class Other_Sceduling_Tool
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listofEmployeeForExport1 = new FinalStaffManager.ListofEmployeeForExport();
            this.otherSchedulingTool1 = new FinalStaffManager.OtherSchedulingTool();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Schedule Export Tool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Schedule Viewer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listofEmployeeForExport1
            // 
            this.listofEmployeeForExport1.AutoScroll = true;
            this.listofEmployeeForExport1.Location = new System.Drawing.Point(6, 43);
            this.listofEmployeeForExport1.Name = "listofEmployeeForExport1";
            this.listofEmployeeForExport1.Size = new System.Drawing.Size(673, 570);
            this.listofEmployeeForExport1.TabIndex = 3;
            // 
            // otherSchedulingTool1
            // 
            this.otherSchedulingTool1.AutoScroll = true;
            this.otherSchedulingTool1.BackColor = System.Drawing.Color.White;
            this.otherSchedulingTool1.Location = new System.Drawing.Point(57, 3);
            this.otherSchedulingTool1.Name = "otherSchedulingTool1";
            this.otherSchedulingTool1.Size = new System.Drawing.Size(622, 591);
            this.otherSchedulingTool1.TabIndex = 2;
            // 
            // Other_Sceduling_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listofEmployeeForExport1);
            this.Controls.Add(this.otherSchedulingTool1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Other_Sceduling_Tool";
            this.Size = new System.Drawing.Size(994, 633);
            this.Load += new System.EventHandler(this.Other_Sceduling_Tool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private OtherSchedulingTool otherSchedulingTool1;
        private ListofEmployeeForExport listofEmployeeForExport1;
    }
}
