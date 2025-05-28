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
    public partial class usShowFinalReport : UserControl
    {
        public usShowFinalReport()
        {
            InitializeComponent();
        }

        void ChangeCheDataGridHeaders()
        {
            dgvViolations.Columns[0].HeaderText = "الاسم الكامل";
            dgvViolations.Columns[1].HeaderText = "مخالفات الصلاة";
            dgvViolations.Columns[2].HeaderText = "مخالفات حلقات الفجر";
            dgvViolations.Columns[3].HeaderText = "مخالفات الأنشطة";
            dgvViolations.Columns[4].HeaderText = "مخالفات السلوك";
            dgvViolations.Columns[5].HeaderText = "مخالفات النظافة";
            dgvViolations.Columns[6].HeaderText = "مخالفة حلقة الأسبوع";
            dgvViolations.Columns[7].HeaderText = "النتيجة النهائية";

            dgvViolations.Columns[0].Width = 200;
            
            dgvViolations.Columns[7].Width = 60;
        }

        void WhenThisUserControlLoaded(string Filter = "")
        {
            DataTable dt = ClsViolationDetailesBusiness.GetFinalReport(Filter);

            if (dt.Rows.Count == 0)
            {
                dt = ClsViolationDetailesBusiness.MakeEmptyDataTableForFinalReport();
            }

            dgvViolations.DataSource = dt;
            ChangeCheDataGridHeaders();
        }

        private void usShowFinalReport_Load(object sender, EventArgs e)
        {
            WhenThisUserControlLoaded();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Query = $" where FullName like N'{txtSearch.Text}%'";

            WhenThisUserControlLoaded(Query);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsViolationManagmenet());
        }

        private void btnShowReportDetailes_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsFinalReportDetailes((string)dgvViolations.CurrentRow.Cells[0].Value, "تفاصيل التقرير النهائي"));
        }
    }
}
