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
    public partial class FrmAddOrUpdateOrShowViolation : Form
    {
        ClsViolationDetailesBusiness clsViolation;

        public FrmAddOrUpdateOrShowViolation(int ID  , bool Show = false)
        {
            InitializeComponent();

            if (ID == -1)
            {
                lbTitle.Text = "إضافة مخالفة";
                clsViolation = new ClsViolationDetailesBusiness();
            }

            else if (Show)
            {
                lbTitle.Text = "تعديل المخالفة ";
                clsViolation = ClsViolationDetailesBusiness.FindByID(ID);
                SetTheValuesForControls();
            }

            else
            {
                lbTitle.Text = "تفاصيل المحالفة";
                clsViolation = ClsViolationDetailesBusiness.FindByID(ID);
                SetTheValuesForControls();
                MakeAllControlsEnabledFalse();
            }
        }

        int returnIndexForItem(string item)
        {
            for(int i = 0; i < cmbViolationFKind.Items.Count; i++)
            {
                if (cmbViolationFKind.Items[i].ToString() == item)
                {
                    return i;
                }
            }

            return 0;
        }

        void SetTheValuesForControls()
        {
            txtStudentName.Text = clsViolation._StudentName;
            cmbViolationFKind.SelectedItem = cmbViolationFKind.Items[returnIndexForItem(clsViolation._ViolationName)];
            dateTimeViolation.Value = clsViolation._ViolationDate;
            txtDescriptionViolation.Text = clsViolation._ViolationDescription;
        }

        private void FrmAddOrUpdateOrShowViolation_Load(object sender, EventArgs e)
        {

        }

        void MakeAllControlsEnabledFalse ()
        {
            foreach(Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        void ClearControlsForNewData()
        {
            txtDescriptionViolation.Text = "";
            txtStudentName.Text = "";
            cmbViolationFKind.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsViolation._StudentID = clsStudentsManagementBusiness.GetStudentIDByName(txtStudentName.Text);
            clsViolation._ViolationID = ClsViolationsBusiness.GetViolationIDByName(cmbViolationFKind.SelectedItem.ToString());
            clsViolation._ViolationDate = dateTimeViolation.Value;
            clsViolation._ViolationDescription = txtDescriptionViolation.Text;

            if (clsViolation.Save())
            {
                if (MessageBox.Show("تمت العملية بنجاح","information",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ClearControlsForNewData();
                }
            }

            else
            {
                MessageBox.Show("لم تتم إضافة المخالفة", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
