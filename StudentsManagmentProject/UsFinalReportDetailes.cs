using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsManagementBusinessLayer;

namespace StudentsManagmentProject
{
    public partial class UsFinalReportDetailes : UserControl
    {
        string _StudentName;
        bool BackToViolationScreen;
        public UsFinalReportDetailes(string StudentName,string Tilte,bool Show = false)
        {
            InitializeComponent();
            _StudentName = StudentName;
            lbTitle.Text = Tilte;
            lbStudentName.Text = StudentName;
            BackToViolationScreen = Show;
        }

        void ChangeTHeDataGridHeaders()
        {
            dgvViolations.Columns[0].HeaderText = "نوع المخالفة";
            dgvViolations.Columns[1].HeaderText = "تاريخ المخالفة";
            dgvViolations.Columns[2].HeaderText = "وصف المخالفة";
            dgvViolations.Columns[3].HeaderText = "إجمالي المخالفات";

            dgvViolations.Columns[3].Width = 70;
            dgvViolations.Columns[0].Width = 125;
            dgvViolations.Columns[1].Width = 115;
            
        }

        void WhenThisUserControlLoaded(string Filter = "")
        {
            DataTable dt = ClsViolationDetailesBusiness.GetStudentViolationByName(_StudentName,Filter);

            if (dt.Rows.Count == 0)
            {
                dt=ClsViolationDetailesBusiness.MakeEmptyTableForFinalReportDetailes();
            }

            dgvViolations.DataSource = dt;
            ChangeTHeDataGridHeaders();
        }

        private void UsFinalReportDetailes_Load(object sender, EventArgs e)
        {
            WhenThisUserControlLoaded();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (BackToViolationScreen)
            {
                clsUserControlManagment.ShowUserControl(new UsViolationManagmenet());
            }

            else
            {
                clsUserControlManagment.ShowUserControl(new usShowFinalReport());
            }
        }

        void _CheckFromContolsForFilters(ref string ViolationName, ref string ViolationDate, ref string Count)
        {
            if (cmbViolationFilter.SelectedItem.ToString() != cmbViolationFilter.Items[0].ToString())
            {
                ViolationName = $" Violations.Name = N'{cmbViolationFilter.SelectedItem.ToString()}'";
            }

            if (ViolationDateTime.Value.ToString() != "01/01/2020 12:00:00 ص")
            {
                string Date = "";
                Date += ViolationDateTime.Value.Year.ToString() + "/";
                Date += ViolationDateTime.Value.Month.ToString() + "/";
                Date += ViolationDateTime.Value.Day.ToString();
                ViolationDate = $" ViolationsDetails.ViolationDate = '{Date}'";
            }

            if (Count != "0")
            {
                Count = $" CountOfViolation >= {ViolationCount.Value.ToString()}";
            }
        }

        string _MakeTheQueryForFiltringData()
        {
            string ViolationName = "";
            string ViolationDate = new DateTime(2020, 1, 1).ToString();
            string Count = "";

            string Query = " and ";

            _CheckFromContolsForFilters(ref ViolationName, ref ViolationDate, ref Count);

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

            if (Query.Length < 7)
            {
                Query = "";
            }

            return Query;
        }

        void _FiltringData()
        {
            string Query = _MakeTheQueryForFiltringData();


            WhenThisUserControlLoaded(Query);
        }

        private void ViolationCount_ValueChanged(object sender, EventArgs e)
        {
            _FiltringData();
        }

        private void ViolationDateTime_ValueChanged(object sender, EventArgs e)
        {
            _FiltringData();
        }

        private void cmbViolationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FiltringData();
        }
    }
}
