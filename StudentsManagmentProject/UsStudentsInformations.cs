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
    public partial class UsStudentsInformations : UserControl
    {
        DataTable dtStudentsInformaions = new DataTable();
        DataTable dtAllMajors = new DataTable();
        DataTable dtAllUniversities = new DataTable();
        DataTable dtAllLevels = new DataTable();
        DataTable dtAllPeriods = new DataTable();
        DataView dvStudentsInformation = new DataView();
        bool IsThisFormLoaded = false;
        public UsStudentsInformations()
        {
            InitializeComponent();
        }

        private void FillEachComboBox(string ColomnName,ComboBox cmbName,string TableName)
        {
            DataTable dt = clsStudentsManagementBusiness.GetWhatYouWantTableInformation(TableName);

            foreach(DataRow Row in dt.Rows)
            {
                cmbName.Items.Add(Row[ColomnName]);
            }
        }
        private void FillAllComboBoxes ()
        {
            FillEachComboBox("LevelName", cmbLevelsFilter, "Levels");
            FillEachComboBox("UniversityName", cmbUniversitiesFilter, "Universities");
            FillEachComboBox("MajorName", cmbMajorsFilter, "Majors");
            FillEachComboBox("PeriodName", cmbPeriodes, "Piordes");
        }

        private void SetDefaultSelectedItemsInComboBoxes()
        {
            IsThisFormLoaded = true;
            cmbUniversitiesFilter.SelectedItem = cmbUniversitiesFilter.Items[0];
            cmbLevelsFilter.SelectedItem = cmbLevelsFilter.Items[0];
            cmbMajorsFilter.SelectedItem = cmbMajorsFilter.Items[0];
            cmbPeriodes.SelectedItem = cmbPeriodes.Items[0];
            cmbStudentsFilter.SelectedItem = cmbStudentsFilter.Items[0];
            IsThisFormLoaded = false;
        }

        private void ChangeTheDataGridViewStudentsHeaders()
        {
            dgvShowStudentsInfo.Columns[0].HeaderText = "الرقم";
            dgvShowStudentsInfo.Columns[1].HeaderText = "الاسم الكامل";
            dgvShowStudentsInfo.Columns[2].HeaderText = "رقم الهاتف";
            dgvShowStudentsInfo.Columns[3].HeaderText = "حالة الطالب";
            dgvShowStudentsInfo.Columns[4].HeaderText = "المستوى الدراسي";
            dgvShowStudentsInfo.Columns[5].HeaderText = "الجامعة";
            dgvShowStudentsInfo.Columns[6].HeaderText = "التخصص";
            dgvShowStudentsInfo.Columns[7].HeaderText = "فترة الدوام";

            dgvShowStudentsInfo.Columns[1].Width = 250;
            dgvShowStudentsInfo.Columns[0].Width = 50;
            dgvShowStudentsInfo.Columns[3].Width = 80;
            dgvShowStudentsInfo.Columns[4].Width = 80;
        }

        private void MakeTheFiletringForComboBoxes(ref string StuFilter,ref string MajFilter,ref string LevFilter,ref string UniFilter,ref string PerFilter)
        {
          
            if (cmbStudentsFilter.SelectedItem != cmbStudentsFilter.Items[0])
            {
                if (cmbStudentsFilter.SelectedItem == cmbStudentsFilter.Items[1])
                {
                    StuFilter = "Students.State=N'خريج' ";
                }

                else
                {
                    StuFilter = "Students.State=N'منتظم'";
                }
            }

            if (cmbLevelsFilter.SelectedItem != cmbLevelsFilter.Items[0])
            {
                LevFilter = $"Levels.LevelName=N'{cmbLevelsFilter.SelectedItem}'";
            }

            if (cmbMajorsFilter.SelectedItem != cmbMajorsFilter.Items[0])
            {
                MajFilter = $"Majors.MajorName=N'{cmbMajorsFilter.SelectedItem}'";
            }

            if (cmbUniversitiesFilter.SelectedItem != cmbUniversitiesFilter.Items[0])
            {
                UniFilter = $"Universities.UniversityName=N'{cmbUniversitiesFilter.SelectedItem}'";
            }

            if (cmbPeriodes.SelectedItem != cmbPeriodes.Items[0])
            {
                PerFilter = $"Piordes.PeriodName=N'{cmbPeriodes.SelectedItem}'";
            }
        }

        private string MakeTheQueryForTheFiltering()
        {
            string Query = " where ";
            string studentsState = "", StudentsMajor = "", StudentsLevel = "", StudentsUniver = "", StudentsPeriod = "";

            MakeTheFiletringForComboBoxes(ref studentsState, ref StudentsMajor, ref StudentsLevel, ref StudentsUniver, ref StudentsPeriod);

            if (studentsState != "")
            {
                Query += studentsState + " and ";
            }

            if (StudentsMajor != "")
            {
                Query += StudentsMajor + " and ";
            }

            if (StudentsLevel != "")
            {
                Query += StudentsLevel + " and ";
            }

            if (StudentsUniver != "")
            {
                Query += StudentsUniver + " and ";
            }

            if (StudentsPeriod != "")
            {
                Query += StudentsPeriod + " and ";
            }

            if (!(Query.Length == 5) && Query != " where ")
            {
                Query = Query.Remove(Query.Length - 4);
            }

            if (Query == " where ")
            {
                Query = "";
            }

            return Query;
        }

        private void WhenComboBoxSelected ()
        {
            string Query = MakeTheQueryForTheFiltering();
            WhenThisUserControlLoaded(Query);
        }

        private void WhenThisUserControlLoaded (string Query)
        {
            dtStudentsInformaions = clsStudentsManagementBusiness.GetStudentsMenueInformation(Query);

            if (dtStudentsInformaions.Rows.Count == 0)
            {
                dtStudentsInformaions = clsStudentsManagementBusiness.MakeEmpityDataTable();
            }
            //dgvShowStudentsInfo.DataSource = dtStudentsInformaions;
            dvStudentsInformation = dtStudentsInformaions.DefaultView;

            dgvShowStudentsInfo.DataSource = dvStudentsInformation;
            ChangeTheDataGridViewStudentsHeaders();
        }

        private void UsStudentsInformations_Load(object sender, EventArgs e)
        {
            WhenThisUserControlLoaded("");
            FillAllComboBoxes();
            SetDefaultSelectedItemsInComboBoxes();
            
        }

        private void cmbStudentsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsThisFormLoaded)
            {
                WhenComboBoxSelected();
            }
        }

        private void cmbUniversitiesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!IsThisFormLoaded)
            {
                WhenComboBoxSelected();
            }
        }

        private void cmbMajorsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsThisFormLoaded)
            {
                WhenComboBoxSelected();
            }
        }

        private void cmbLevelsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsThisFormLoaded)
            {
                WhenComboBoxSelected();
            }
        }

        private void cmbPeriodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsThisFormLoaded)
            {
                WhenComboBoxSelected();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string Query = $" Where Students.FullName like "+ $"N'{txtSearch.Text}%' ";
                WhenThisUserControlLoaded(Query);
            }

            else
            {
                WhenThisUserControlLoaded("");
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            FrmAddNewStudent AddNuewStudent = new FrmAddNewStudent(-1,"إضافة طالب");
            AddNuewStudent.ShowDialog();
            WhenThisUserControlLoaded("");
        }

        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            FrmAddNewStudent UbdateNewStudent = new FrmAddNewStudent((int)dgvShowStudentsInfo.CurrentRow.Cells[0].Value,"");
            UbdateNewStudent.ShowDialog();
            WhenThisUserControlLoaded("");
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            FrmAddNewStudent UbdateNewStudent = new FrmAddNewStudent((int)dgvShowStudentsInfo.CurrentRow.Cells[0].Value, "معلومات الطالب");
            UbdateNewStudent.ShowDialog();
            WhenThisUserControlLoaded("");
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if ((int)dgvShowStudentsInfo.CurrentRow.Cells[0].Value > 0)
            {
                if (MessageBox.Show("Are you shur to delete this Student ","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    clsStudentsManagementBusiness.DeleteStudent((int)dgvShowStudentsInfo.CurrentRow.Cells[0].Value);
                    WhenThisUserControlLoaded("");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WhenThisUserControlLoaded("");
            SetDefaultSelectedItemsInComboBoxes();
        }
    }
}
