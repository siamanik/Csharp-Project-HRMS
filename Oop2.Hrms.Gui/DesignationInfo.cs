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

namespace Oop2.Hrms.Gui
{
    public partial class DesignationInfo : Form
    {
        HRDBEntities _context = new HRDBEntities();
        DesiInfoBL _deptInfoBL = new DesiInfoBL();
        List<DesiInfo> _deptInfos = new List<DesiInfo>();
        DesiInfo _selectedDesiInfo = null;
        private int _selectIndex = 0;

        public DesignationInfo()
        {
            InitializeComponent();
        }

        private void DesiInfo_Load(object sender, EventArgs e)
        {
            this.Init();
        }


        private void Init()
        {
            try
            {
                

                txtSearch.Text = "";
               this.loadDesiInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadDesiInfo()
        {
            _deptInfos = _deptInfoBL.GetAll(txtSearch.Text);

            if (_deptInfos.Count > 0)
            {
                _selectedDesiInfo = _deptInfos[0];
                _selectIndex = 0;

            }
            else
            {
                _selectedDesiInfo = new DesiInfo();
            }
            this.Populate();
            this.RefreshDgv();
        }


        private void Populate()
        {
            txtBoxID.Text = _selectedDesiInfo.ID.ToString();
            txtBoxName.Text = _selectedDesiInfo.Name;
        }

        private void RefreshDgv()
        {
            dgvDesiList.AutoGenerateColumns = false;
            dgvDesiList.DataSource = _deptInfos.ToList();
            dgvDesiList.Refresh();

            dgvDesiList.ClearSelection();

            for (int i = 0; i < dgvDesiList.Rows.Count; i++)
            {
                if (dgvDesiList.Rows[i].Cells[0].Value.ToString() == _selectedDesiInfo.ID.ToString())
                {
                    dgvDesiList.Rows[i].Selected = true;
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
            this.loadDesiInfo();
        }

        private void dgvDesiList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedDesiInfo = _deptInfos[e.RowIndex];
                _selectIndex = e.RowIndex;
                this.Populate();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedDesiInfo=new DesiInfo();
            this.Populate();
            dgvDesiList.ClearSelection();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_selectedDesiInfo.ID == 0)
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
            if (_deptInfoBL.Delete(_selectedDesiInfo.ID, out error) == false)
            {
                MetroFramework.MetroMessageBox.Show(this, error);
                return;
            }

            _deptInfos.Remove(_selectedDesiInfo);
            this.RefreshDgv();
            MetroFramework.MetroMessageBox.Show(this, "Operation Completed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedDesiInfo.Name = txtBoxName.Text;

                bool isNew = _selectedDesiInfo.ID == 0;

                string error;
                _selectedDesiInfo = _deptInfoBL.Save(_selectedDesiInfo, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, error);
                    return;
                }

                this.Populate();

                if (isNew)
                    _deptInfos.Add(_selectedDesiInfo);
                else
                {
                    _deptInfos[_selectIndex] = _selectedDesiInfo;
                }

                MetroFramework.MetroMessageBox.Show(this, "Operation Completed");
                RefreshDgv();
            }
            catch (Exception exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Input is not correct");
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
