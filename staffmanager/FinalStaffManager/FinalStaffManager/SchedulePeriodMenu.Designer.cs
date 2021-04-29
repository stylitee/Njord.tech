namespace FinalStaffManager
{
    partial class schedulePeriodMenu
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlListOfSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeadDisplay = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtrEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtrBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.pnlSchedulingHead = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSchedStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.btnSetter = new System.Windows.Forms.Button();
            this.lblCoverStatus = new System.Windows.Forms.Label();
            this.pnlSchedulingBody = new System.Windows.Forms.Panel();
            this.cmbListofRotationCode = new System.Windows.Forms.ComboBox();
            this.pnlEmployeeList = new System.Windows.Forms.Panel();
            this.cmbEmployee1 = new System.Windows.Forms.ComboBox();
            this.cmbEmployee2 = new System.Windows.Forms.ComboBox();
            this.cmbEmployee3 = new System.Windows.Forms.ComboBox();
            this.cmbEmployee4 = new System.Windows.Forms.ComboBox();
            this.cmbEmployee5 = new System.Windows.Forms.ComboBox();
            this.lblrcode = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRotationCode = new System.Windows.Forms.Label();
            this.pnlScodeList = new System.Windows.Forms.Panel();
            this.lblScode1 = new System.Windows.Forms.Label();
            this.lblScode2 = new System.Windows.Forms.Label();
            this.lblScode3 = new System.Windows.Forms.Label();
            this.lblScode4 = new System.Windows.Forms.Label();
            this.lblScode5 = new System.Windows.Forms.Label();
            this.btnPrintSchedule = new System.Windows.Forms.Button();
            this.btnDayOff = new System.Windows.Forms.Button();
            this.pnlHeadDisplay.SuspendLayout();
            this.pnlRegistration.SuspendLayout();
            this.pnlSchedulingHead.SuspendLayout();
            this.pnlCover.SuspendLayout();
            this.pnlSchedulingBody.SuspendLayout();
            this.pnlEmployeeList.SuspendLayout();
            this.pnlScodeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "ADD NEW SCHEDULER PERIOD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "SCHEDULE PERIOD MANAGER";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(369, 50);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 13);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "List of Schedule Period";
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // pnlListOfSchedule
            // 
            this.pnlListOfSchedule.AutoScroll = true;
            this.pnlListOfSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListOfSchedule.Location = new System.Drawing.Point(66, 101);
            this.pnlListOfSchedule.Name = "pnlListOfSchedule";
            this.pnlListOfSchedule.Size = new System.Drawing.Size(730, 289);
            this.pnlListOfSchedule.TabIndex = 48;
            // 
            // pnlHeadDisplay
            // 
            this.pnlHeadDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHeadDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeadDisplay.Controls.Add(this.label6);
            this.pnlHeadDisplay.Controls.Add(this.label5);
            this.pnlHeadDisplay.Controls.Add(this.label18);
            this.pnlHeadDisplay.Controls.Add(this.label12);
            this.pnlHeadDisplay.Controls.Add(this.label2);
            this.pnlHeadDisplay.Location = new System.Drawing.Point(66, 69);
            this.pnlHeadDisplay.Name = "pnlHeadDisplay";
            this.pnlHeadDisplay.Size = new System.Drawing.Size(730, 33);
            this.pnlHeadDisplay.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "With Schedule";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(574, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "CONTROLS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Schedule";
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
            this.pnlRegistration.Controls.Add(this.label4);
            this.pnlRegistration.Controls.Add(this.label3);
            this.pnlRegistration.Controls.Add(this.dtrEndDate);
            this.pnlRegistration.Controls.Add(this.dtrBeginDate);
            this.pnlRegistration.Location = new System.Drawing.Point(268, 70);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(341, 303);
            this.pnlRegistration.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Begin date: ";
            // 
            // dtrEndDate
            // 
            this.dtrEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtrEndDate.Location = new System.Drawing.Point(24, 141);
            this.dtrEndDate.Name = "dtrEndDate";
            this.dtrEndDate.Size = new System.Drawing.Size(292, 20);
            this.dtrEndDate.TabIndex = 1;
            // 
            // dtrBeginDate
            // 
            this.dtrBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtrBeginDate.Location = new System.Drawing.Point(24, 65);
            this.dtrBeginDate.Name = "dtrBeginDate";
            this.dtrBeginDate.Size = new System.Drawing.Size(292, 20);
            this.dtrBeginDate.TabIndex = 0;
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Location = new System.Drawing.Point(3, 0);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(0, 13);
            this.lblIndicator.TabIndex = 53;
            this.lblIndicator.TextChanged += new System.EventHandler(this.lblIndicator_TextChanged);
            // 
            // pnlSchedulingHead
            // 
            this.pnlSchedulingHead.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSchedulingHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchedulingHead.Controls.Add(this.label8);
            this.pnlSchedulingHead.Controls.Add(this.label7);
            this.pnlSchedulingHead.Controls.Add(this.lblSchedStatus);
            this.pnlSchedulingHead.Controls.Add(this.button1);
            this.pnlSchedulingHead.Controls.Add(this.cmbDate);
            this.pnlSchedulingHead.Controls.Add(this.lblDate);
            this.pnlSchedulingHead.Location = new System.Drawing.Point(46, 69);
            this.pnlSchedulingHead.Name = "pnlSchedulingHead";
            this.pnlSchedulingHead.Size = new System.Drawing.Size(750, 33);
            this.pnlSchedulingHead.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = ">";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSchedStatus
            // 
            this.lblSchedStatus.AutoSize = true;
            this.lblSchedStatus.Location = new System.Drawing.Point(696, 10);
            this.lblSchedStatus.Name = "lblSchedStatus";
            this.lblSchedStatus.Size = new System.Drawing.Size(35, 13);
            this.lblSchedStatus.TabIndex = 3;
            this.lblSchedStatus.Text = "label7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(69, 8);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 21);
            this.cmbDate.TabIndex = 1;
            this.cmbDate.TextChanged += new System.EventHandler(this.cmbDate_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // pnlCover
            // 
            this.pnlCover.Controls.Add(this.btnSetter);
            this.pnlCover.Controls.Add(this.lblCoverStatus);
            this.pnlCover.Location = new System.Drawing.Point(20, 2);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(711, 268);
            this.pnlCover.TabIndex = 0;
            // 
            // btnSetter
            // 
            this.btnSetter.AutoSize = true;
            this.btnSetter.Location = new System.Drawing.Point(319, 153);
            this.btnSetter.Name = "btnSetter";
            this.btnSetter.Size = new System.Drawing.Size(75, 23);
            this.btnSetter.TabIndex = 1;
            this.btnSetter.Text = "button1";
            this.btnSetter.UseVisualStyleBackColor = true;
            this.btnSetter.SizeChanged += new System.EventHandler(this.btnSetter_SizeChanged);
            this.btnSetter.Click += new System.EventHandler(this.btnSetter_Click);
            // 
            // lblCoverStatus
            // 
            this.lblCoverStatus.AutoSize = true;
            this.lblCoverStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoverStatus.Location = new System.Drawing.Point(265, 103);
            this.lblCoverStatus.Name = "lblCoverStatus";
            this.lblCoverStatus.Size = new System.Drawing.Size(195, 22);
            this.lblCoverStatus.TabIndex = 0;
            this.lblCoverStatus.Text = "Please select a Date";
            this.lblCoverStatus.SizeChanged += new System.EventHandler(this.lblCoverStatus_SizeChanged);
            this.lblCoverStatus.TextChanged += new System.EventHandler(this.lblCoverStatus_TextChanged);
            // 
            // pnlSchedulingBody
            // 
            this.pnlSchedulingBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchedulingBody.Controls.Add(this.pnlCover);
            this.pnlSchedulingBody.Controls.Add(this.cmbListofRotationCode);
            this.pnlSchedulingBody.Controls.Add(this.pnlEmployeeList);
            this.pnlSchedulingBody.Controls.Add(this.lblrcode);
            this.pnlSchedulingBody.Controls.Add(this.btnBack);
            this.pnlSchedulingBody.Controls.Add(this.btnSave);
            this.pnlSchedulingBody.Controls.Add(this.lblRotationCode);
            this.pnlSchedulingBody.Controls.Add(this.pnlScodeList);
            this.pnlSchedulingBody.Location = new System.Drawing.Point(46, 101);
            this.pnlSchedulingBody.Name = "pnlSchedulingBody";
            this.pnlSchedulingBody.Size = new System.Drawing.Size(750, 289);
            this.pnlSchedulingBody.TabIndex = 0;
            // 
            // cmbListofRotationCode
            // 
            this.cmbListofRotationCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListofRotationCode.FormattingEnabled = true;
            this.cmbListofRotationCode.Location = new System.Drawing.Point(158, 3);
            this.cmbListofRotationCode.Name = "cmbListofRotationCode";
            this.cmbListofRotationCode.Size = new System.Drawing.Size(121, 21);
            this.cmbListofRotationCode.TabIndex = 16;
            this.cmbListofRotationCode.TextChanged += new System.EventHandler(this.cmbListofRotationCode_TextChanged);
            // 
            // pnlEmployeeList
            // 
            this.pnlEmployeeList.Controls.Add(this.cmbEmployee1);
            this.pnlEmployeeList.Controls.Add(this.cmbEmployee2);
            this.pnlEmployeeList.Controls.Add(this.cmbEmployee3);
            this.pnlEmployeeList.Controls.Add(this.cmbEmployee4);
            this.pnlEmployeeList.Controls.Add(this.cmbEmployee5);
            this.pnlEmployeeList.Location = new System.Drawing.Point(268, 34);
            this.pnlEmployeeList.Name = "pnlEmployeeList";
            this.pnlEmployeeList.Size = new System.Drawing.Size(254, 178);
            this.pnlEmployeeList.TabIndex = 15;
            // 
            // cmbEmployee1
            // 
            this.cmbEmployee1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee1.FormattingEnabled = true;
            this.cmbEmployee1.Location = new System.Drawing.Point(13, 3);
            this.cmbEmployee1.Name = "cmbEmployee1";
            this.cmbEmployee1.Size = new System.Drawing.Size(224, 21);
            this.cmbEmployee1.TabIndex = 7;
            this.cmbEmployee1.TextChanged += new System.EventHandler(this.cmbEmployee1_TextChanged);
            // 
            // cmbEmployee2
            // 
            this.cmbEmployee2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee2.FormattingEnabled = true;
            this.cmbEmployee2.Location = new System.Drawing.Point(13, 39);
            this.cmbEmployee2.Name = "cmbEmployee2";
            this.cmbEmployee2.Size = new System.Drawing.Size(224, 21);
            this.cmbEmployee2.TabIndex = 8;
            // 
            // cmbEmployee3
            // 
            this.cmbEmployee3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee3.FormattingEnabled = true;
            this.cmbEmployee3.Location = new System.Drawing.Point(13, 73);
            this.cmbEmployee3.Name = "cmbEmployee3";
            this.cmbEmployee3.Size = new System.Drawing.Size(224, 21);
            this.cmbEmployee3.TabIndex = 9;
            // 
            // cmbEmployee4
            // 
            this.cmbEmployee4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee4.FormattingEnabled = true;
            this.cmbEmployee4.Location = new System.Drawing.Point(13, 107);
            this.cmbEmployee4.Name = "cmbEmployee4";
            this.cmbEmployee4.Size = new System.Drawing.Size(224, 21);
            this.cmbEmployee4.TabIndex = 10;
            // 
            // cmbEmployee5
            // 
            this.cmbEmployee5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee5.FormattingEnabled = true;
            this.cmbEmployee5.Location = new System.Drawing.Point(13, 144);
            this.cmbEmployee5.Name = "cmbEmployee5";
            this.cmbEmployee5.Size = new System.Drawing.Size(224, 21);
            this.cmbEmployee5.TabIndex = 11;
            // 
            // lblrcode
            // 
            this.lblrcode.AutoSize = true;
            this.lblrcode.Location = new System.Drawing.Point(113, 6);
            this.lblrcode.Name = "lblrcode";
            this.lblrcode.Size = new System.Drawing.Size(0, 13);
            this.lblrcode.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(317, 247);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRotationCode
            // 
            this.lblRotationCode.AutoSize = true;
            this.lblRotationCode.Location = new System.Drawing.Point(30, 6);
            this.lblRotationCode.Name = "lblRotationCode";
            this.lblRotationCode.Size = new System.Drawing.Size(81, 13);
            this.lblRotationCode.TabIndex = 1;
            this.lblRotationCode.Text = "Rotation Code: ";
            // 
            // pnlScodeList
            // 
            this.pnlScodeList.Controls.Add(this.lblScode1);
            this.pnlScodeList.Controls.Add(this.lblScode2);
            this.pnlScodeList.Controls.Add(this.lblScode3);
            this.pnlScodeList.Controls.Add(this.lblScode4);
            this.pnlScodeList.Controls.Add(this.lblScode5);
            this.pnlScodeList.Location = new System.Drawing.Point(211, 34);
            this.pnlScodeList.Name = "pnlScodeList";
            this.pnlScodeList.Size = new System.Drawing.Size(96, 178);
            this.pnlScodeList.TabIndex = 17;
            // 
            // lblScode1
            // 
            this.lblScode1.AutoSize = true;
            this.lblScode1.Location = new System.Drawing.Point(15, 6);
            this.lblScode1.Name = "lblScode1";
            this.lblScode1.Size = new System.Drawing.Size(53, 13);
            this.lblScode1.TabIndex = 2;
            this.lblScode1.Text = "SCODE 1";
            // 
            // lblScode2
            // 
            this.lblScode2.AutoSize = true;
            this.lblScode2.Location = new System.Drawing.Point(15, 42);
            this.lblScode2.Name = "lblScode2";
            this.lblScode2.Size = new System.Drawing.Size(53, 13);
            this.lblScode2.TabIndex = 3;
            this.lblScode2.Text = "SCODE 1";
            // 
            // lblScode3
            // 
            this.lblScode3.AutoSize = true;
            this.lblScode3.Location = new System.Drawing.Point(15, 76);
            this.lblScode3.Name = "lblScode3";
            this.lblScode3.Size = new System.Drawing.Size(53, 13);
            this.lblScode3.TabIndex = 4;
            this.lblScode3.Text = "SCODE 1";
            // 
            // lblScode4
            // 
            this.lblScode4.AutoSize = true;
            this.lblScode4.Location = new System.Drawing.Point(15, 110);
            this.lblScode4.Name = "lblScode4";
            this.lblScode4.Size = new System.Drawing.Size(53, 13);
            this.lblScode4.TabIndex = 5;
            this.lblScode4.Text = "SCODE 1";
            // 
            // lblScode5
            // 
            this.lblScode5.AutoSize = true;
            this.lblScode5.Location = new System.Drawing.Point(15, 147);
            this.lblScode5.Name = "lblScode5";
            this.lblScode5.Size = new System.Drawing.Size(53, 13);
            this.lblScode5.TabIndex = 6;
            this.lblScode5.Text = "SCODE 1";
            // 
            // btnPrintSchedule
            // 
            this.btnPrintSchedule.Location = new System.Drawing.Point(673, 396);
            this.btnPrintSchedule.Name = "btnPrintSchedule";
            this.btnPrintSchedule.Size = new System.Drawing.Size(123, 48);
            this.btnPrintSchedule.TabIndex = 56;
            this.btnPrintSchedule.Text = "Print Schedule";
            this.btnPrintSchedule.UseVisualStyleBackColor = true;
            this.btnPrintSchedule.Click += new System.EventHandler(this.btnPrintSchedule_Click);
            // 
            // btnDayOff
            // 
            this.btnDayOff.Location = new System.Drawing.Point(571, 396);
            this.btnDayOff.Name = "btnDayOff";
            this.btnDayOff.Size = new System.Drawing.Size(96, 48);
            this.btnDayOff.TabIndex = 57;
            this.btnDayOff.Text = "Set Employee Day Off";
            this.btnDayOff.UseVisualStyleBackColor = true;
            this.btnDayOff.Click += new System.EventHandler(this.btnDayOff_Click);
            // 
            // schedulePeriodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDayOff);
            this.Controls.Add(this.btnPrintSchedule);
            this.Controls.Add(this.pnlSchedulingBody);
            this.Controls.Add(this.pnlSchedulingHead);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlListOfSchedule);
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.pnlHeadDisplay);
            this.Controls.Add(this.btnAdd);
            this.Name = "schedulePeriodMenu";
            this.Size = new System.Drawing.Size(844, 521);
            this.Load += new System.EventHandler(this.SchedulePeriodMenu_Load);
            this.pnlHeadDisplay.ResumeLayout(false);
            this.pnlHeadDisplay.PerformLayout();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.pnlSchedulingHead.ResumeLayout(false);
            this.pnlSchedulingHead.PerformLayout();
            this.pnlCover.ResumeLayout(false);
            this.pnlCover.PerformLayout();
            this.pnlSchedulingBody.ResumeLayout(false);
            this.pnlSchedulingBody.PerformLayout();
            this.pnlEmployeeList.ResumeLayout(false);
            this.pnlScodeList.ResumeLayout(false);
            this.pnlScodeList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.FlowLayoutPanel pnlListOfSchedule;
        public System.Windows.Forms.Panel pnlHeadDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtrEndDate;
        private System.Windows.Forms.DateTimePicker dtrBeginDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblIndicator;
        public System.Windows.Forms.Panel pnlSchedulingHead;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.Label lblCoverStatus;
        private System.Windows.Forms.Panel pnlSchedulingBody;
        private System.Windows.Forms.Button btnSetter;
        private System.Windows.Forms.ComboBox cmbEmployee5;
        private System.Windows.Forms.ComboBox cmbEmployee4;
        private System.Windows.Forms.ComboBox cmbEmployee3;
        private System.Windows.Forms.ComboBox cmbEmployee2;
        private System.Windows.Forms.ComboBox cmbEmployee1;
        private System.Windows.Forms.Label lblScode5;
        private System.Windows.Forms.Label lblScode4;
        private System.Windows.Forms.Label lblScode3;
        private System.Windows.Forms.Label lblScode2;
        private System.Windows.Forms.Label lblScode1;
        private System.Windows.Forms.Label lblRotationCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblrcode;
        private System.Windows.Forms.Panel pnlEmployeeList;
        private System.Windows.Forms.ComboBox cmbListofRotationCode;
        private System.Windows.Forms.Panel pnlScodeList;
        private System.Windows.Forms.Button btnPrintSchedule;
        private System.Windows.Forms.Label lblSchedStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDayOff;

    }
}
