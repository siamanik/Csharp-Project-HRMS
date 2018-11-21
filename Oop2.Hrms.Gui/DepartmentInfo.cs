using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oop2.Hrms.BL;
using Oop2.Hrms.Data;
using Oop2.Hrms.Framework;

namespace Oop2.Hrms.Gui
{
    public partial class DepartmentInfo : Form
    {
        HRDBEntities _context = new HRDBEntities();
        DeptInfoBL _deptInfoBL = new DeptInfoBL();
        List<DeptInfo> _deptInfos = new List<DeptInfo>();
        DeptInfo _selectedDeptInfo = null;
        private int _selectIndex = 0;

        public DepartmentInfo()
        {
            InitializeComponent();
        }

        private void DeptInfo_Load(object sender, EventArgs e)
        {
            this.Init();
        }


        private void Init()
        {
            try
            {
                

                txtSearch.Text = "";
               this.loadDeptInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadDeptInfo()
        {
            _deptInfos = _deptInfoBL.GetAll(txtSearch.Text);

            if (_deptInfos.Count > 0)
            {
                _selectedDeptInfo = _deptInfos[0];
                _selectIndex = 0;

            }
            else
            {
                _selectedDeptInfo = new DeptInfo();
            }
            this.Populate();
            this.RefreshDgv();
        }


        private void Populate()
        {
            txtBoxID.Text = _selectedDeptInfo.ID.ToString();
            txtBoxName.Text = _selectedDeptInfo.Name;
        }

        private void RefreshDgv()
        {
            dgvDeptList.AutoGenerateColumns = false;
            dgvDeptList.DataSource = _deptInfos.ToList();
            dgvDeptList.Refresh();

            dgvDeptList.ClearSelection();

            for (int i = 0; i < dgvDeptList.Rows.Count; i++)
            {
                if (dgvDeptList.Rows[i].Cells[0].Value.ToString() == _selectedDeptInfo.ID.ToString())
                {
                    dgvDeptList.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();

        }

        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            this.loadDeptInfo();
        }

        private void dgvDeptList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedDeptInfo = _deptInfos[e.RowIndex];
                _selectIndex = e.RowIndex;
                this.Populate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedDeptInfo=new DeptInfo();
            this.Populate();
            dgvDeptList.ClearSelection();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_selectedDeptInfo.ID == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select A Row First");
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                return;
            }

            string error;
            if (_deptInfoBL.Delete(_selectedDeptInfo.ID, out error) == false)
            {
                MetroFramework.MetroMessageBox.Show(this, error);
                return;
            }

            _deptInfos.Remove(_selectedDeptInfo);
            this.RefreshDgv();
            MetroFramework.MetroMessageBox.Show(this, "Operation Completed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedDeptInfo.Name = txtBoxName.Text;

                bool isNew = _selectedDeptInfo.ID == 0;

                string error;
                _selectedDeptInfo = _deptInfoBL.Save(_selectedDeptInfo, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, error);
                    return;
                }

                this.Populate();

                if (isNew)
                    _deptInfos.Add(_selectedDeptInfo);
                else
                {
                    _deptInfos[_selectIndex] = _selectedDeptInfo;
                }

                MetroFramework.MetroMessageBox.Show(this, "Operation Completed");
                RefreshDgv();
            }
            catch (Exception exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Input is not correct");
            }
        }

        private void dgvDeptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
