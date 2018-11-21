namespace Oop2.Hrms.Gui
{
    partial class EmpInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanal4 = new MetroFramework.Controls.MetroPanel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.txtBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxID = new MetroFramework.Controls.MetroTextBox();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.ddlDesi = new MetroFramework.Controls.MetroComboBox();
            this.lblDesiID = new MetroFramework.Controls.MetroLabel();
            this.ddlStatus = new MetroFramework.Controls.MetroComboBox();
            this.lblStatusID = new MetroFramework.Controls.MetroLabel();
            this.dtpJoindate = new MetroFramework.Controls.MetroDateTime();
            this.lblJoinDate = new MetroFramework.Controls.MetroLabel();
            this.txtBoxLn = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxFn = new MetroFramework.Controls.MetroTextBox();
            this.lblFn = new MetroFramework.Controls.MetroLabel();
            this.ddlGender = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxPass = new MetroFramework.Controls.MetroTextBox();
            this.txtboxEmail = new MetroFramework.Controls.MetroTextBox();
            this.dtpDOB = new MetroFramework.Controls.MetroDateTime();
            this.ddlDept = new MetroFramework.Controls.MetroComboBox();
            this.ddlType = new MetroFramework.Controls.MetroComboBox();
            this.lblDOB = new MetroFramework.Controls.MetroLabel();
            this.lblDeptID = new MetroFramework.Controls.MetroLabel();
            this.lblTypeID = new MetroFramework.Controls.MetroLabel();
            this.lblGender = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblLn = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeInfoManager = new MetroFramework.Controls.MetroPanel();
            this.dgvEmployeeInfoList = new MetroFramework.Controls.MetroGrid();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSearch = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanal4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.EmployeeInfoManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 798);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroPanal4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(974, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 792);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // metroPanal4
            // 
            this.metroPanal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanal4.Controls.Add(this.lblPhone);
            this.metroPanal4.Controls.Add(this.txtBoxPhone);
            this.metroPanal4.Controls.Add(this.txtBoxID);
            this.metroPanal4.Controls.Add(this.lblID);
            this.metroPanal4.Controls.Add(this.ddlDesi);
            this.metroPanal4.Controls.Add(this.lblDesiID);
            this.metroPanal4.Controls.Add(this.ddlStatus);
            this.metroPanal4.Controls.Add(this.lblStatusID);
            this.metroPanal4.Controls.Add(this.dtpJoindate);
            this.metroPanal4.Controls.Add(this.lblJoinDate);
            this.metroPanal4.Controls.Add(this.txtBoxLn);
            this.metroPanal4.Controls.Add(this.txtBoxFn);
            this.metroPanal4.Controls.Add(this.lblFn);
            this.metroPanal4.Controls.Add(this.ddlGender);
            this.metroPanal4.Controls.Add(this.txtBoxPass);
            this.metroPanal4.Controls.Add(this.txtboxEmail);
            this.metroPanal4.Controls.Add(this.dtpDOB);
            this.metroPanal4.Controls.Add(this.ddlDept);
            this.metroPanal4.Controls.Add(this.ddlType);
            this.metroPanal4.Controls.Add(this.lblDOB);
            this.metroPanal4.Controls.Add(this.lblDeptID);
            this.metroPanal4.Controls.Add(this.lblTypeID);
            this.metroPanal4.Controls.Add(this.lblGender);
            this.metroPanal4.Controls.Add(this.lblPassword);
            this.metroPanal4.Controls.Add(this.lblEmail);
            this.metroPanal4.Controls.Add(this.lblLn);
            this.metroPanal4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanal4.HorizontalScrollbarBarColor = true;
            this.metroPanal4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanal4.HorizontalScrollbarSize = 10;
            this.metroPanal4.Location = new System.Drawing.Point(3, 53);
            this.metroPanal4.Name = "metroPanal4";
            this.metroPanal4.Size = new System.Drawing.Size(388, 736);
            this.metroPanal4.TabIndex = 0;
            this.metroPanal4.VerticalScrollbarBarColor = true;
            this.metroPanal4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanal4.VerticalScrollbarSize = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(40, 287);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 20);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone:";
            // 
            // txtBoxPhone
            // 
            // 
            // 
            // 
            this.txtBoxPhone.CustomButton.Image = null;
            this.txtBoxPhone.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxPhone.CustomButton.Name = "";
            this.txtBoxPhone.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPhone.CustomButton.TabIndex = 1;
            this.txtBoxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPhone.CustomButton.UseSelectable = true;
            this.txtBoxPhone.CustomButton.Visible = false;
            this.txtBoxPhone.Lines = new string[0];
            this.txtBoxPhone.Location = new System.Drawing.Point(141, 287);
            this.txtBoxPhone.MaxLength = 32767;
            this.txtBoxPhone.Multiline = true;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.PasswordChar = '\0';
            this.txtBoxPhone.PromptText = "Phone";
            this.txtBoxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPhone.SelectedText = "";
            this.txtBoxPhone.SelectionLength = 0;
            this.txtBoxPhone.SelectionStart = 0;
            this.txtBoxPhone.ShortcutsEnabled = true;
            this.txtBoxPhone.Size = new System.Drawing.Size(231, 40);
            this.txtBoxPhone.TabIndex = 16;
            this.txtBoxPhone.UseSelectable = true;
            this.txtBoxPhone.WaterMark = "Phone";
            this.txtBoxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxID
            // 
            // 
            // 
            // 
            this.txtBoxID.CustomButton.Image = null;
            this.txtBoxID.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxID.CustomButton.Name = "";
            this.txtBoxID.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxID.CustomButton.TabIndex = 1;
            this.txtBoxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxID.CustomButton.UseSelectable = true;
            this.txtBoxID.CustomButton.Visible = false;
            this.txtBoxID.Lines = new string[0];
            this.txtBoxID.Location = new System.Drawing.Point(141, 3);
            this.txtBoxID.MaxLength = 32767;
            this.txtBoxID.Multiline = true;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PasswordChar = '\0';
            this.txtBoxID.PromptText = "ID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxID.SelectedText = "";
            this.txtBoxID.SelectionLength = 0;
            this.txtBoxID.SelectionStart = 0;
            this.txtBoxID.ShortcutsEnabled = true;
            this.txtBoxID.Size = new System.Drawing.Size(231, 40);
            this.txtBoxID.TabIndex = 29;
            this.txtBoxID.UseSelectable = true;
            this.txtBoxID.WaterMark = "ID";
            this.txtBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(67, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "ID:";
            // 
            // ddlDesi
            // 
            this.ddlDesi.FormattingEnabled = true;
            this.ddlDesi.ItemHeight = 24;
            this.ddlDesi.Location = new System.Drawing.Point(141, 525);
            this.ddlDesi.Name = "ddlDesi";
            this.ddlDesi.Size = new System.Drawing.Size(231, 30);
            this.ddlDesi.TabIndex = 27;
            this.ddlDesi.UseSelectable = true;
            // 
            // lblDesiID
            // 
            this.lblDesiID.AutoSize = true;
            this.lblDesiID.Location = new System.Drawing.Point(7, 525);
            this.lblDesiID.Name = "lblDesiID";
            this.lblDesiID.Size = new System.Drawing.Size(85, 20);
            this.lblDesiID.TabIndex = 26;
            this.lblDesiID.Text = "Designation:";
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.ItemHeight = 24;
            this.ddlStatus.Location = new System.Drawing.Point(141, 429);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(231, 30);
            this.ddlStatus.TabIndex = 25;
            this.ddlStatus.UseSelectable = true;
            // 
            // lblStatusID
            // 
            this.lblStatusID.AutoSize = true;
            this.lblStatusID.Location = new System.Drawing.Point(27, 429);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(65, 20);
            this.lblStatusID.TabIndex = 24;
            this.lblStatusID.Text = "Status ID:";
            // 
            // dtpJoindate
            // 
            this.dtpJoindate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoindate.Location = new System.Drawing.Point(141, 607);
            this.dtpJoindate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpJoindate.Name = "dtpJoindate";
            this.dtpJoindate.Size = new System.Drawing.Size(231, 30);
            this.dtpJoindate.TabIndex = 23;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(23, 607);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(69, 20);
            this.lblJoinDate.TabIndex = 22;
            this.lblJoinDate.Text = "Join Date:";
            // 
            // txtBoxLn
            // 
            // 
            // 
            // 
            this.txtBoxLn.CustomButton.Image = null;
            this.txtBoxLn.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxLn.CustomButton.Name = "";
            this.txtBoxLn.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxLn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxLn.CustomButton.TabIndex = 1;
            this.txtBoxLn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxLn.CustomButton.UseSelectable = true;
            this.txtBoxLn.CustomButton.Visible = false;
            this.txtBoxLn.Lines = new string[0];
            this.txtBoxLn.Location = new System.Drawing.Point(141, 111);
            this.txtBoxLn.MaxLength = 32767;
            this.txtBoxLn.Multiline = true;
            this.txtBoxLn.Name = "txtBoxLn";
            this.txtBoxLn.PasswordChar = '\0';
            this.txtBoxLn.PromptText = "Last Name";
            this.txtBoxLn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxLn.SelectedText = "";
            this.txtBoxLn.SelectionLength = 0;
            this.txtBoxLn.SelectionStart = 0;
            this.txtBoxLn.ShortcutsEnabled = true;
            this.txtBoxLn.Size = new System.Drawing.Size(231, 40);
            this.txtBoxLn.TabIndex = 12;
            this.txtBoxLn.UseSelectable = true;
            this.txtBoxLn.WaterMark = "Last Name";
            this.txtBoxLn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxLn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxFn
            // 
            // 
            // 
            // 
            this.txtBoxFn.CustomButton.Image = null;
            this.txtBoxFn.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxFn.CustomButton.Name = "";
            this.txtBoxFn.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxFn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFn.CustomButton.TabIndex = 1;
            this.txtBoxFn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFn.CustomButton.UseSelectable = true;
            this.txtBoxFn.CustomButton.Visible = false;
            this.txtBoxFn.Lines = new string[0];
            this.txtBoxFn.Location = new System.Drawing.Point(141, 58);
            this.txtBoxFn.MaxLength = 32767;
            this.txtBoxFn.Multiline = true;
            this.txtBoxFn.Name = "txtBoxFn";
            this.txtBoxFn.PasswordChar = '\0';
            this.txtBoxFn.PromptText = "First Name";
            this.txtBoxFn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFn.SelectedText = "";
            this.txtBoxFn.SelectionLength = 0;
            this.txtBoxFn.SelectionStart = 0;
            this.txtBoxFn.ShortcutsEnabled = true;
            this.txtBoxFn.Size = new System.Drawing.Size(231, 40);
            this.txtBoxFn.TabIndex = 11;
            this.txtBoxFn.UseSelectable = true;
            this.txtBoxFn.WaterMark = "First Name";
            this.txtBoxFn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.Location = new System.Drawing.Point(13, 58);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(79, 20);
            this.lblFn.TabIndex = 2;
            this.lblFn.Text = "First Name:";
            // 
            // ddlGender
            // 
            this.ddlGender.FormattingEnabled = true;
            this.ddlGender.ItemHeight = 24;
            this.ddlGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddlGender.Location = new System.Drawing.Point(141, 338);
            this.ddlGender.Name = "ddlGender";
            this.ddlGender.Size = new System.Drawing.Size(231, 30);
            this.ddlGender.TabIndex = 16;
            this.ddlGender.UseSelectable = true;
            // 
            // txtBoxPass
            // 
            // 
            // 
            // 
            this.txtBoxPass.CustomButton.Image = null;
            this.txtBoxPass.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxPass.CustomButton.Name = "";
            this.txtBoxPass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPass.CustomButton.TabIndex = 1;
            this.txtBoxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPass.CustomButton.UseSelectable = true;
            this.txtBoxPass.CustomButton.Visible = false;
            this.txtBoxPass.Lines = new string[0];
            this.txtBoxPass.Location = new System.Drawing.Point(141, 228);
            this.txtBoxPass.MaxLength = 32767;
            this.txtBoxPass.Multiline = true;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '#';
            this.txtBoxPass.PromptText = "Password";
            this.txtBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPass.SelectedText = "";
            this.txtBoxPass.SelectionLength = 0;
            this.txtBoxPass.SelectionStart = 0;
            this.txtBoxPass.ShortcutsEnabled = true;
            this.txtBoxPass.Size = new System.Drawing.Size(231, 40);
            this.txtBoxPass.TabIndex = 14;
            this.txtBoxPass.UseSelectable = true;
            this.txtBoxPass.WaterMark = "Password";
            this.txtBoxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtboxEmail
            // 
            // 
            // 
            // 
            this.txtboxEmail.CustomButton.Image = null;
            this.txtboxEmail.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtboxEmail.CustomButton.Name = "";
            this.txtboxEmail.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtboxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxEmail.CustomButton.TabIndex = 1;
            this.txtboxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxEmail.CustomButton.UseSelectable = true;
            this.txtboxEmail.CustomButton.Visible = false;
            this.txtboxEmail.Lines = new string[0];
            this.txtboxEmail.Location = new System.Drawing.Point(141, 168);
            this.txtboxEmail.MaxLength = 32767;
            this.txtboxEmail.Multiline = true;
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.PasswordChar = '\0';
            this.txtboxEmail.PromptText = "Email";
            this.txtboxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxEmail.SelectedText = "";
            this.txtboxEmail.SelectionLength = 0;
            this.txtboxEmail.SelectionStart = 0;
            this.txtboxEmail.ShortcutsEnabled = true;
            this.txtboxEmail.Size = new System.Drawing.Size(231, 40);
            this.txtboxEmail.TabIndex = 13;
            this.txtboxEmail.UseSelectable = true;
            this.txtboxEmail.WaterMark = "Email";
            this.txtboxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(141, 571);
            this.dtpDOB.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(231, 30);
            this.dtpDOB.TabIndex = 19;
            // 
            // ddlDept
            // 
            this.ddlDept.FormattingEnabled = true;
            this.ddlDept.ItemHeight = 24;
            this.ddlDept.Location = new System.Drawing.Point(141, 476);
            this.ddlDept.Name = "ddlDept";
            this.ddlDept.Size = new System.Drawing.Size(231, 30);
            this.ddlDept.TabIndex = 18;
            this.ddlDept.UseSelectable = true;
            this.ddlDept.SelectedIndexChanged += new System.EventHandler(this.ddlDept_SelectedIndexChanged);
            // 
            // ddlType
            // 
            this.ddlType.FormattingEnabled = true;
            this.ddlType.ItemHeight = 24;
            this.ddlType.Location = new System.Drawing.Point(141, 383);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(231, 30);
            this.ddlType.TabIndex = 17;
            this.ddlType.UseSelectable = true;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(51, 571);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(41, 20);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "DOB:";
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(5, 476);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(87, 20);
            this.lblDeptID.TabIndex = 9;
            this.lblDeptID.Text = "Department:";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Location = new System.Drawing.Point(33, 383);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(59, 20);
            this.lblTypeID.TabIndex = 8;
            this.lblTypeID.Text = "Type ID:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(32, 338);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 228);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblLn
            // 
            this.lblLn.AutoSize = true;
            this.lblLn.Location = new System.Drawing.Point(14, 111);
            this.lblLn.Name = "lblLn";
            this.lblLn.Size = new System.Drawing.Size(78, 20);
            this.lblLn.TabIndex = 3;
            this.lblLn.Text = "Last Name:";
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.mbtnSave);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(3, 3);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(388, 44);
            this.metroPanel5.TabIndex = 1;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(21, 3);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(90, 34);
            this.mbtnSave.TabIndex = 6;
            this.mbtnSave.Text = "Save";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.EmployeeInfoManager, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(965, 792);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // EmployeeInfoManager
            // 
            this.EmployeeInfoManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeInfoManager.Controls.Add(this.dgvEmployeeInfoList);
            this.EmployeeInfoManager.Controls.Add(this.metroGrid1);
            this.EmployeeInfoManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeInfoManager.HorizontalScrollbarBarColor = true;
            this.EmployeeInfoManager.HorizontalScrollbarHighlightOnWheel = false;
            this.EmployeeInfoManager.HorizontalScrollbarSize = 10;
            this.EmployeeInfoManager.Location = new System.Drawing.Point(3, 53);
            this.EmployeeInfoManager.Name = "EmployeeInfoManager";
            this.EmployeeInfoManager.Size = new System.Drawing.Size(959, 736);
            this.EmployeeInfoManager.TabIndex = 0;
            this.EmployeeInfoManager.VerticalScrollbarBarColor = true;
            this.EmployeeInfoManager.VerticalScrollbarHighlightOnWheel = false;
            this.EmployeeInfoManager.VerticalScrollbarSize = 10;
            // 
            // dgvEmployeeInfoList
            // 
            this.dgvEmployeeInfoList.AllowUserToAddRows = false;
            this.dgvEmployeeInfoList.AllowUserToDeleteRows = false;
            this.dgvEmployeeInfoList.AllowUserToResizeRows = false;
            this.dgvEmployeeInfoList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmployeeInfoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeInfoList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployeeInfoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeInfoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvfn,
            this.dgvEmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeInfoList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeInfoList.EnableHeadersVisualStyles = false;
            this.dgvEmployeeInfoList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEmployeeInfoList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmployeeInfoList.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeInfoList.Name = "dgvEmployeeInfoList";
            this.dgvEmployeeInfoList.ReadOnly = true;
            this.dgvEmployeeInfoList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeInfoList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeInfoList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployeeInfoList.RowTemplate.Height = 24;
            this.dgvEmployeeInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInfoList.Size = new System.Drawing.Size(957, 734);
            this.dgvEmployeeInfoList.TabIndex = 3;
            this.dgvEmployeeInfoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfoList_CellClick);
            this.dgvEmployeeInfoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeInfoList_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvfn
            // 
            this.dgvfn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvfn.DataPropertyName = "FullName";
            this.dgvfn.HeaderText = "Full Name";
            this.dgvfn.Name = "dgvfn";
            this.dgvfn.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            this.dgvEmail.Width = 180;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 2;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.txtSearch);
            this.metroPanel3.Controls.Add(this.mbtnSearch);
            this.metroPanel3.Controls.Add(this.btnRefresh);
            this.metroPanel3.Controls.Add(this.btnNew);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(959, 44);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(394, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(204, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(426, 34);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnSearch
            // 
            this.mbtnSearch.Location = new System.Drawing.Point(636, 3);
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(90, 34);
            this.mbtnSearch.TabIndex = 5;
            this.mbtnSearch.Text = "Search";
            this.mbtnSearch.UseSelectable = true;
            this.mbtnSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(99, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 34);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // EmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 798);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmpInfo";
            this.Text = "Employee Info";
            this.Load += new System.EventHandler(this.EmpInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanal4.ResumeLayout(false);
            this.metroPanal4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.EmployeeInfoManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroPanel metroPanal4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel EmployeeInfoManager;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel lblDOB;
        private MetroFramework.Controls.MetroLabel lblDeptID;
        private MetroFramework.Controls.MetroLabel lblTypeID;
        private MetroFramework.Controls.MetroLabel lblGender;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblLn;
        private MetroFramework.Controls.MetroLabel lblFn;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton mbtnSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroTextBox txtBoxPass;
        private MetroFramework.Controls.MetroTextBox txtboxEmail;
        private MetroFramework.Controls.MetroTextBox txtBoxLn;
        private MetroFramework.Controls.MetroTextBox txtBoxFn;
        private MetroFramework.Controls.MetroDateTime dtpDOB;
        private MetroFramework.Controls.MetroComboBox ddlDept;
        private MetroFramework.Controls.MetroComboBox ddlType;
        private MetroFramework.Controls.MetroComboBox ddlGender;
        private MetroFramework.Controls.MetroDateTime dtpJoindate;
        private MetroFramework.Controls.MetroLabel lblJoinDate;
        private MetroFramework.Controls.MetroComboBox ddlStatus;
        private MetroFramework.Controls.MetroLabel lblStatusID;
        private MetroFramework.Controls.MetroComboBox ddlDesi;
        private MetroFramework.Controls.MetroLabel lblDesiID;
        private MetroFramework.Controls.MetroTextBox txtBoxID;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroGrid dgvEmployeeInfoList;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroTextBox txtBoxPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
    }
}