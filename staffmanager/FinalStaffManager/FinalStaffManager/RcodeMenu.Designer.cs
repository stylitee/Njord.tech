namespace FinalStaffManager
{
    partial class RcodeMenu
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlListofRcode = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbScodeList = new System.Windows.Forms.ComboBox();
            this.panelChoices = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbNumberOfEmployees = new System.Windows.Forms.ComboBox();
            this.txtRcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHead.SuspendLayout();
            this.pnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 23);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "ADD NEW RCODE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.TextChanged += new System.EventHandler(this.btnSave_TextChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "RCODE MANAGER";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(387, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "List of Rcode";
            // 
            // pnlListofRcode
            // 
            this.pnlListofRcode.AutoScroll = true;
            this.pnlListofRcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListofRcode.Location = new System.Drawing.Point(68, 89);
            this.pnlListofRcode.Name = "pnlListofRcode";
            this.pnlListofRcode.Size = new System.Drawing.Size(730, 282);
            this.pnlListofRcode.TabIndex = 42;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHead.Controls.Add(this.label5);
            this.pnlHead.Controls.Add(this.label18);
            this.pnlHead.Controls.Add(this.label12);
            this.pnlHead.Controls.Add(this.label11);
            this.pnlHead.Controls.Add(this.label2);
            this.pnlHead.Location = new System.Drawing.Point(68, 62);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(730, 33);
            this.pnlHead.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SCODE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(595, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "CONTROLS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "DESCRIPTION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "RCODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No.";
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegistration.Controls.Add(this.btnAdd);
            this.pnlRegistration.Controls.Add(this.cmbScodeList);
            this.pnlRegistration.Controls.Add(this.panelChoices);
            this.pnlRegistration.Controls.Add(this.cmbNumberOfEmployees);
            this.pnlRegistration.Controls.Add(this.txtRcode);
            this.pnlRegistration.Controls.Add(this.label4);
            this.pnlRegistration.Controls.Add(this.label3);
            this.pnlRegistration.Location = new System.Drawing.Point(245, 64);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(341, 303);
            this.pnlRegistration.TabIndex = 44;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbScodeList
            // 
            this.cmbScodeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScodeList.FormattingEnabled = true;
            this.cmbScodeList.Location = new System.Drawing.Point(18, 78);
            this.cmbScodeList.Name = "cmbScodeList";
            this.cmbScodeList.Size = new System.Drawing.Size(203, 21);
            this.cmbScodeList.TabIndex = 0;
            // 
            // panelChoices
            // 
            this.panelChoices.AutoScroll = true;
            this.panelChoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChoices.Location = new System.Drawing.Point(18, 105);
            this.panelChoices.Name = "panelChoices";
            this.panelChoices.Size = new System.Drawing.Size(301, 160);
            this.panelChoices.TabIndex = 35;
            this.panelChoices.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelChoices_ControlRemoved);
            // 
            // cmbNumberOfEmployees
            // 
            this.cmbNumberOfEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberOfEmployees.FormattingEnabled = true;
            this.cmbNumberOfEmployees.Items.AddRange(new object[] {
            "",
            "5 Employees",
            "4 Employees",
            "3 Employees",
            "2 Employees",
            "1 Employees"});
            this.cmbNumberOfEmployees.Location = new System.Drawing.Point(131, 49);
            this.cmbNumberOfEmployees.Name = "cmbNumberOfEmployees";
            this.cmbNumberOfEmployees.Size = new System.Drawing.Size(178, 21);
            this.cmbNumberOfEmployees.TabIndex = 34;
            this.cmbNumberOfEmployees.TextChanged += new System.EventHandler(this.cmbNumberOfEmployees_TextChanged);
            // 
            // txtRcode
            // 
            this.txtRcode.Location = new System.Drawing.Point(131, 20);
            this.txtRcode.MaxLength = 1;
            this.txtRcode.Name = "txtRcode";
            this.txtRcode.Size = new System.Drawing.Size(178, 20);
            this.txtRcode.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Number of Employee: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rotation Code:";
            // 
            // RcodeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlListofRcode);
            this.Name = "RcodeMenu";
            this.Size = new System.Drawing.Size(844, 521);
            this.Load += new System.EventHandler(this.RcodeMenu_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.FlowLayoutPanel pnlListofRcode;
        public System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbScodeList;
        public System.Windows.Forms.FlowLayoutPanel panelChoices;
        public System.Windows.Forms.ComboBox cmbNumberOfEmployees;
        public System.Windows.Forms.TextBox txtRcode;
        private System.Windows.Forms.Label label5;

    }
}
