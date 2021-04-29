namespace FinalStaffManager
{
    partial class SchedulePeriodRow
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblNumberOfSchedule = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(13, 8);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(21, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "No";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(44, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "id";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(69, 8);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(33, 13);
            this.lblBegin.TabIndex = 2;
            this.lblBegin.Text = "begin";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(145, 8);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(25, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "end";
            // 
            // lblNumberOfSchedule
            // 
            this.lblNumberOfSchedule.AutoSize = true;
            this.lblNumberOfSchedule.Location = new System.Drawing.Point(297, 8);
            this.lblNumberOfSchedule.Name = "lblNumberOfSchedule";
            this.lblNumberOfSchedule.Size = new System.Drawing.Size(71, 13);
            this.lblNumberOfSchedule.TabIndex = 4;
            this.lblNumberOfSchedule.Text = "withSchedule";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(364, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "status";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(620, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(98, 23);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Scheduling Tool";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(539, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(458, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SchedulePeriodRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNumberOfSchedule);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblItem);
            this.Name = "SchedulePeriodRow";
            this.Size = new System.Drawing.Size(721, 30);
            this.Load += new System.EventHandler(this.SchedulePeriodRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBegin;
        public System.Windows.Forms.Label lblEnd;
        public System.Windows.Forms.Label lblNumberOfSchedule;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnSchedule;
        public System.Windows.Forms.Label lblItem;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;

    }
}
