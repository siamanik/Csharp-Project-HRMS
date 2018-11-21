namespace Oop2.Hrms.Gui
{
    partial class DepartmentInfo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanal4 = new MetroFramework.Controls.MetroPanel();
            this.txtBoxName = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxID = new MetroFramework.Controls.MetroTextBox();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPan = new MetroFramework.Controls.MetroPanel();
            this.dgvDeptList = new MetroFramework.Controls.MetroGrid();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSearch = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanal4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.dgvPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptList)).BeginInit();
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
            this.metroPanal4.Controls.Add(this.txtBoxName);
            this.metroPanal4.Controls.Add(this.txtBoxID);
            this.metroPanal4.Controls.Add(this.lblID);
            this.metroPanal4.Controls.Add(this.lblName);
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
            // txtBoxName
            // 
            // 
            // 
            // 
            this.txtBoxName.CustomButton.Image = null;
            this.txtBoxName.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtBoxName.CustomButton.Name = "";
            this.txtBoxName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxName.CustomButton.TabIndex = 1;
            this.txtBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxName.CustomButton.UseSelectable = true;
            this.txtBoxName.CustomButton.Visible = false;
            this.txtBoxName.Lines = new string[0];
            this.txtBoxName.Location = new System.Drawing.Point(105, 75);
            this.txtBoxName.MaxLength = 32767;
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PasswordChar = '\0';
            this.txtBoxName.PromptText = "Name";
            this.txtBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.SelectionLength = 0;
            this.txtBoxName.SelectionStart = 0;
            this.txtBoxName.ShortcutsEnabled = true;
            this.txtBoxName.Size = new System.Drawing.Size(231, 40);
            this.txtBoxName.TabIndex = 12;
            this.txtBoxName.UseSelectable = true;
            this.txtBoxName.WaterMark = "Name";
            this.txtBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtBoxID.Location = new System.Drawing.Point(105, 18);
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
            this.txtBoxID.TabIndex = 11;
            this.txtBoxID.UseSelectable = true;
            this.txtBoxID.WaterMark = "ID";
            this.txtBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(72, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.btnSave);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvPan, 0, 1);
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
            // dgvPan
            // 
            this.dgvPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPan.Controls.Add(this.dgvDeptList);
            this.dgvPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPan.HorizontalScrollbarBarColor = true;
            this.dgvPan.HorizontalScrollbarHighlightOnWheel = false;
            this.dgvPan.HorizontalScrollbarSize = 10;
            this.dgvPan.Location = new System.Drawing.Point(3, 53);
            this.dgvPan.Name = "dgvPan";
            this.dgvPan.Size = new System.Drawing.Size(959, 736);
            this.dgvPan.TabIndex = 0;
            this.dgvPan.VerticalScrollbarBarColor = true;
            this.dgvPan.VerticalScrollbarHighlightOnWheel = false;
            this.dgvPan.VerticalScrollbarSize = 10;
            // 
            // dgvDeptList
            // 
            this.dgvDeptList.AllowUserToAddRows = false;
            this.dgvDeptList.AllowUserToDeleteRows = false;
            this.dgvDeptList.AllowUserToResizeRows = false;
            this.dgvDeptList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDeptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeptList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeptList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeptList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvDeptName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeptList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeptList.EnableHeadersVisualStyles = false;
            this.dgvDeptList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDeptList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDeptList.Location = new System.Drawing.Point(0, 0);
            this.dgvDeptList.MultiSelect = false;
            this.dgvDeptList.Name = "dgvDeptList";
            this.dgvDeptList.ReadOnly = true;
            this.dgvDeptList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeptList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeptList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeptList.RowTemplate.Height = 24;
            this.dgvDeptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeptList.Size = new System.Drawing.Size(957, 734);
            this.dgvDeptList.TabIndex = 2;
            this.dgvDeptList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptList_CellClick);
            this.dgvDeptList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptList_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvDeptName
            // 
            this.dgvDeptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDeptName.DataPropertyName = "Name";
            this.dgvDeptName.HeaderText = "Name";
            this.dgvDeptName.Name = "dgvDeptName";
            this.dgvDeptName.ReadOnly = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.txtSearch);
            this.metroPanel3.Controls.Add(this.mbtnSearch);
            this.metroPanel3.Controls.Add(this.btnRefresh);
            this.metroPanel3.Controls.Add(this.btnDel);
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
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
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
            this.txtSearch.Location = new System.Drawing.Point(352, 3);
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
            this.mbtnSearch.Location = new System.Drawing.Point(797, 3);
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(90, 34);
            this.mbtnSearch.TabIndex = 5;
            this.mbtnSearch.Text = "Search";
            this.mbtnSearch.UseSelectable = true;
            this.mbtnSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(218, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(111, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            // DepartmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 798);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepartmentInfo";
            this.Text = "Department Info";
            this.Load += new System.EventHandler(this.DeptInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanal4.ResumeLayout(false);
            this.metroPanal4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.dgvPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptList)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroPanel metroPanal4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel dgvPan;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton mbtnSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroTextBox txtBoxName;
        private MetroFramework.Controls.MetroTextBox txtBoxID;
        private MetroFramework.Controls.MetroGrid dgvDeptList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeptName;
    }
}