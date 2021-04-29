namespace FinalStaffManager
{
    partial class srsScodeItems
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
            this.lblCodeName = new System.Windows.Forms.Label();
            this.lblCodeDescription = new System.Windows.Forms.Label();
            this.lblFirstTimeIn = new System.Windows.Forms.Label();
            this.lblFirstOut = new System.Windows.Forms.Label();
            this.lblSecondIn = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSecondOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(14, 9);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "num";
            // 
            // lblCodeName
            // 
            this.lblCodeName.AutoSize = true;
            this.lblCodeName.Location = new System.Drawing.Point(81, 9);
            this.lblCodeName.Name = "lblCodeName";
            this.lblCodeName.Size = new System.Drawing.Size(31, 13);
            this.lblCodeName.TabIndex = 1;
            this.lblCodeName.Text = "code";
            // 
            // lblCodeDescription
            // 
            this.lblCodeDescription.AutoSize = true;
            this.lblCodeDescription.Location = new System.Drawing.Point(156, 9);
            this.lblCodeDescription.Name = "lblCodeDescription";
            this.lblCodeDescription.Size = new System.Drawing.Size(30, 13);
            this.lblCodeDescription.TabIndex = 2;
            this.lblCodeDescription.Text = "desc";
            // 
            // lblFirstTimeIn
            // 
            this.lblFirstTimeIn.AutoSize = true;
            this.lblFirstTimeIn.Location = new System.Drawing.Point(247, 9);
            this.lblFirstTimeIn.Name = "lblFirstTimeIn";
            this.lblFirstTimeIn.Size = new System.Drawing.Size(29, 13);
            this.lblFirstTimeIn.TabIndex = 3;
            this.lblFirstTimeIn.Text = "1stin";
            // 
            // lblFirstOut
            // 
            this.lblFirstOut.AutoSize = true;
            this.lblFirstOut.Location = new System.Drawing.Point(282, 9);
            this.lblFirstOut.Name = "lblFirstOut";
            this.lblFirstOut.Size = new System.Drawing.Size(36, 13);
            this.lblFirstOut.TabIndex = 4;
            this.lblFirstOut.Text = "1stout";
            // 
            // lblSecondIn
            // 
            this.lblSecondIn.AutoSize = true;
            this.lblSecondIn.Location = new System.Drawing.Point(421, 9);
            this.lblSecondIn.Name = "lblSecondIn";
            this.lblSecondIn.Size = new System.Drawing.Size(34, 13);
            this.lblSecondIn.TabIndex = 5;
            this.lblSecondIn.Text = "2ndIn";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Image = global::FinalStaffManager.Properties.Resources.process;
            this.btnUpdate.Location = new System.Drawing.Point(609, -5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(39, 43);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Image = global::FinalStaffManager.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(654, -5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 41);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSecondOut
            // 
            this.lblSecondOut.AutoSize = true;
            this.lblSecondOut.Location = new System.Drawing.Point(461, 9);
            this.lblSecondOut.Name = "lblSecondOut";
            this.lblSecondOut.Size = new System.Drawing.Size(42, 13);
            this.lblSecondOut.TabIndex = 8;
            this.lblSecondOut.Text = "2ndOut";
            // 
            // srsScodeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSecondOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSecondIn);
            this.Controls.Add(this.lblFirstOut);
            this.Controls.Add(this.lblFirstTimeIn);
            this.Controls.Add(this.lblCodeDescription);
            this.Controls.Add(this.lblCodeName);
            this.Controls.Add(this.lblItem);
            this.Name = "srsScodeItems";
            this.Size = new System.Drawing.Size(708, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblItem;
        public System.Windows.Forms.Label lblCodeName;
        public System.Windows.Forms.Label lblCodeDescription;
        public System.Windows.Forms.Label lblFirstTimeIn;
        public System.Windows.Forms.Label lblFirstOut;
        public System.Windows.Forms.Label lblSecondIn;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblSecondOut;
    }
}
