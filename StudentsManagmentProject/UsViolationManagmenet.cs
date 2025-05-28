using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsManagementBusinessLayer;

namespace StudentsManagmentProject
{
    public partial class UsViolationManagmenet : UserControl
    {
        public UsViolationManagmenet()
        {
            InitializeComponent();
        }

        bool IsThisFormLoaded;
        void ChangeTheDataGridColumnsSize()
        {
            dgvViolations.Columns[0].HeaderText = "الرقم";
            dgvViolations.Columns[1].HeaderText = "اسم الطالب";
            dgvViolations.Columns[2].HeaderText = "نوع المخالفة";
            dgvViolations.Columns[3].HeaderText = "تاريخ المخالفة";
            dgvViolations.Columns[4].HeaderText = "عدد المخالفات";

            dgvViolations.Columns[0].Width = 50;
            dgvViolations.Columns[4].Width = 90;
        }

        void WhenThisUserControlLoaded(string Filter = "")
        {
            DataTable dt = ClsViolationDetailesBusiness.GetViolationsDetailes(Filter);

            if(dt.Rows.Count == 0)
            {
                dt = ClsViolationDetailesBusiness.MakeEmptyTableForViolations();
            }

            dgvViolations.DataSource = dt;

            ChangeTheDataGridColumnsSize();
        }

        private void UsViolationManagmenet_Load(object sender, EventArgs e)
        {
            WhenThisUserControlLoaded();

            IsThisFormLoaded = true;

            cmbViolationFilter.SelectedItem = cmbViolationFilter.Items[0];
            IsThisFormLoaded = false;
        }

        void _CheckFromContolsForFilters(ref string ViolationName,ref string ViolationDate,ref string Count)
        {
            if(cmbViolationFilter.SelectedItem.ToString() !=  cmbViolationFilter.Items[0].ToString())
            {
                ViolationName = $" Violations.Name = N'{cmbViolationFilter.SelectedItem.ToString()}'";
            }

            if(ViolationDateTime.Value.ToString() != "01/01/2020 12:00:00 ص")
            {
                string Date = "";
                Date += ViolationDateTime.Value.Year.ToString() + "/";
                Date += ViolationDateTime.Value.Month.ToString() + "/";
                Date += ViolationDateTime.Value.Day.ToString() ;
                ViolationDate = $" ViolationsDetails.ViolationDate = '{Date}'";
            }

            if(Count != "0")
            {
                Count = $" CountOfViolation >= {ViolationCount.Value.ToString()}";
            }
        }

        string _MakeTheQueryForFiltringData()
        {
            string ViolationName = "";
            string ViolationDate = new DateTime(2020, 1, 1).ToString();
            string Count = "";

            string Query = " where ";

            _CheckFromContolsForFilters(ref ViolationName,ref ViolationDate,ref Count);

            if (ViolationName != "")
            {
                Query += ViolationName + " and "; 
            }

            if (ViolationDate != "01/01/2020 12:00:00 ص")
            {
                Query += ViolationDate + " and ";
            }

            if (Count != "0")
            {
                Query += Count + " and ";
            }

            Query = Query.Remove(Query.Length - 5, 4);

            if (Query .Length < 7)
            {
                Query = "";
            }

            return Query;
        }

        void _FiltringData()
        {
            string Query = _MakeTheQueryForFiltringData();

            if (txtSearch.Text != "")
            {
                if (Query != "")
                {
                    Query += $" and Students.FullName like N'{txtSearch.Text}%'";
                }

                else
                {
                    Query += $" where Students.FullName like N'{txtSearch.Text}%'";
                }
            }

            WhenThisUserControlLoaded(Query);
        }

        private void ViolationCount_ValueChanged(object sender, EventArgs e)
        {
            _FiltringData();
        }

        private void cmbViolationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsThisFormLoaded)
            {
                _FiltringData();
            }
        }

        private void ViolationDateTime_ValueChanged(object sender, EventArgs e)
        {
            _FiltringData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _FiltringData();
        }

        private void btnAddViolation_Click(object sender, EventArgs e)
        {
            FrmAddOrUpdateOrShowViolation frm = new FrmAddOrUpdateOrShowViolation(-1);
            frm.ShowDialog();
            WhenThisUserControlLoaded();
        }

        private void btnUpdateViolation_Click(object sender, EventArgs e)
        {
            FrmAddOrUpdateOrShowViolation frm = new FrmAddOrUpdateOrShowViolation((int)dgvViolations.CurrentRow.Cells[0].Value,true);
            frm.ShowDialog();
            WhenThisUserControlLoaded();
        }

        private void btnDetailsViolation_Click(object sender, EventArgs e)
        {
            FrmAddOrUpdateOrShowViolation frm = new FrmAddOrUpdateOrShowViolation((int)dgvViolations.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            WhenThisUserControlLoaded();
        }

        private void btnRemoveViolation_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you shure to delete Violation Student {(string)dgvViolations.CurrentRow.Cells[1].Value} and violation {(string)dgvViolations.CurrentRow.Cells[2].Value}","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if(ClsViolationDetailesBusiness.DeleteViolation((int)dgvViolations.CurrentRow.Cells[0].Value))
                {
                    WhenThisUserControlLoaded();
                }
            }
        }


        private void btnShowAllViolation_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsFinalReportDetailes((string)dgvViolations.CurrentRow.Cells[1].Value, "جميع مخالفات الطالب",true));
        }

        private void btnFinalReport_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new usShowFinalReport());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsStatisticsManagment());
        }
    }
}
