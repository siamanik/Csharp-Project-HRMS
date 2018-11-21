using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Oop2.Hrms.BL;
using Oop2.Hrms.Data;
using Oop2.Hrms.Framework;

namespace Oop2.Hrms.Gui
{
    public partial class EmpInfo : Form
    {
        HRDBEntities _context = new HRDBEntities();
        EmployeeInfoBL _employeeInfoBL = new EmployeeInfoBL();
        List<EmployeeInfo> _employeeInfoes = new List<EmployeeInfo>();
        private EmployeeInfo _selectedEmployeeInfo = null;
        private int _selectedIndex = 0;


        public EmpInfo()
        {
            InitializeComponent();
        }

        private void EmpInfo_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Init()
        {
            try
            {
                ddlType.DataSource = EnumCollection.UserTypeList();
                ddlType.DisplayMember = "Name";
                ddlType.ValueMember = "ID";


                ddlStatus.DataSource = EnumCollection.UserStatusList();
                ddlStatus.DisplayMember = "Name";
                ddlStatus.ValueMember = "ID";

                ddlDept.DataSource = _context.DeptInfoes.ToList();
                ddlDept.DisplayMember = "Name";
                ddlDept.ValueMember = "ID";

                ddlDesi.DataSource = _context.DesiInfoes.ToList();
                ddlDesi.DisplayMember = "Name";
                ddlDesi.ValueMember = "ID";

                txtSearch.Text = "";
                ddlGender.Text = null;
                this.loadEmployeeInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadEmployeeInfo()
        {
            _employeeInfoes = _employeeInfoBL.GetAll(txtSearch.Text);

            if (_employeeInfoes.Count > 0)
            {
                _selectedEmployeeInfo = _employeeInfoes[0];
                _selectedIndex = 0;
            }
            else
            {
                _selectedEmployeeInfo = new EmployeeInfo()
                {
                    UserInfo = new UserInfo()
                    {
                        DOB = DateTime.Now
                    },JoinDate = DateTime.Now
                };
            }

            this.Populate();
            this.RefreshDgv();
        }

        private void RefreshDgv()
        {
            dgvEmployeeInfoList.AutoGenerateColumns = false;
            dgvEmployeeInfoList.DataSource = _employeeInfoes.ToList();
            dgvEmployeeInfoList.Refresh();

            dgvEmployeeInfoList.ClearSelection();

            for (int i = 0; i < dgvEmployeeInfoList.Rows.Count; i++)
            {
                if (dgvEmployeeInfoList.Rows[i].Cells[0].Value.ToString() == _selectedEmployeeInfo.ID.ToString())
                {
                    dgvEmployeeInfoList.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void Populate()
        {
            txtBoxID.Text = _selectedEmployeeInfo.ID.ToString();
            txtBoxFn.Text = _selectedEmployeeInfo.UserInfo.FirstName;
            txtBoxLn.Text = _selectedEmployeeInfo.UserInfo.LastName;
            txtBoxPass.Text = _selectedEmployeeInfo.UserInfo.Password;
            txtboxEmail.Text = _selectedEmployeeInfo.UserInfo.Email;
            txtBoxPhone.Text = _selectedEmployeeInfo.UserInfo.Phone;
            //txtUserID.Text = _selectedEmployeeInfo.OrgID;
            ddlGender.Text = _selectedEmployeeInfo.UserInfo.Gender;
            ddlType.SelectedValue = _selectedEmployeeInfo.UserInfo.TypeID;
            ddlStatus.SelectedValue = _selectedEmployeeInfo.UserInfo.StatusID;
            ddlDept.SelectedValue = _selectedEmployeeInfo.DeptID;
            ddlDesi.SelectedValue = _selectedEmployeeInfo.DesiID;
            dtpJoindate.Text = _selectedEmployeeInfo.JoinDate.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            this.loadEmployeeInfo();
        }

        private void dgvEmployeeInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedEmployeeInfo = _employeeInfoes[e.RowIndex];
                _selectedIndex = e.RowIndex;
                this.Populate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedEmployeeInfo = new EmployeeInfo()
            {
                UserInfo = new UserInfo()
                {
                    DOB = DateTime.Now
                },JoinDate = DateTime.Now
            };

            this.Populate();
            dgvEmployeeInfoList.ClearSelection();
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedEmployeeInfo.UserInfo.FirstName = txtBoxFn.Text;
                _selectedEmployeeInfo.UserInfo.LastName = txtBoxLn.Text;
                _selectedEmployeeInfo.UserInfo.Password = txtBoxPass.Text;
                _selectedEmployeeInfo.UserInfo.DOB = Convert.ToDateTime(dtpDOB.Text);
                _selectedEmployeeInfo.UserInfo.TypeID = Int32.Parse(ddlType.SelectedValue.ToString());
                _selectedEmployeeInfo.UserInfo.Email = txtboxEmail.Text;
                _selectedEmployeeInfo.UserInfo.Gender = ddlGender.Text;
                _selectedEmployeeInfo.UserInfo.Phone = txtBoxPhone.Text;
                _selectedEmployeeInfo.UserInfo.StatusID = Int32.Parse(ddlStatus.SelectedValue.ToString());

                _selectedEmployeeInfo.JoinDate = Convert.ToDateTime(dtpJoindate.Text);
                _selectedEmployeeInfo.DeptID = Int32.Parse(ddlDept.SelectedValue.ToString());
                _selectedEmployeeInfo.DesiID = Int32.Parse(ddlDesi.SelectedValue.ToString());

                bool isNew = _selectedEmployeeInfo.ID == 0;

                string error;
                _selectedEmployeeInfo = _employeeInfoBL.Save(_selectedEmployeeInfo, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, error);
                    return;
                }

                this.Populate();

                if (isNew)
                    _employeeInfoes.Add(_selectedEmployeeInfo);
                else
                {
                    _employeeInfoes[_selectedIndex] = _selectedEmployeeInfo;
                }

                MetroFramework.MetroMessageBox.Show(this, "Operation Completed");
                RefreshDgv();
            }
            catch (Exception exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Input is not correct");
            }
        }

        private void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployeeInfoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
