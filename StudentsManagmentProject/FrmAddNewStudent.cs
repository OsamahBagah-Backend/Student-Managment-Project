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
    public partial class FrmAddNewStudent : Form
    {
        enum enMode { Add=0,Update=1};
        enMode Mode = enMode.Add;
        int StudentID;
        string personalImage = "";
        string ProofImage = "";
        string CardImage = "";
        string FormImage = "";
        
        clsStudentsManagementBusiness Student;
        public FrmAddNewStudent(int ID,string titleName)
        {
            InitializeComponent();

            if (ID != -1)
            {
                this.Mode = enMode.Update;
                StudentID = ID;
            }

            else
            {
                this.Mode = enMode.Add;
            }

            lbTitle.Text = titleName;
        }

        void openFolderDialogSettings ()
        {
            //openFileDialog1.InitialDirectory = @"C:\";
            
            //ChooseImages.Title = "This Title / Open ";
            
            ChooseImages.DefaultExt = "png";
             
            ChooseImages.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
        }
        void FillComboBoxEach(string TableName,ComboBox comboBoxName,string ColumnName)
        {
            DataTable Table = clsStudentsManagementBusiness.GetWhatYouWantTableInformation(TableName);

            foreach(DataRow Row in Table.Rows)
            {
                comboBoxName.Items.Add(Row[ColumnName]);
            }
        }

        void FillAllComboBoxws()
        {
            FillComboBoxEach("Majors order by ID", cmbMajor, "MajorName");
            FillComboBoxEach("Universities order by ID", cmbUniversity, "UniversityName");
            FillComboBoxEach("Levels order by ID", cmbLevels, "LevelName");
            FillComboBoxEach("Piordes order by ID", cmbPeriods, "PeriodName");
        }

        void setTheStudentInformationToControls()
        {
            personalImage = Student.PersonalImage;
            ProofImage = Student.ProofImage;
            CardImage = Student.CardImage;
            FormImage = Student.FormImage;
            txtFullName.Text = Student.FullName;
            DateOfBirth.Value = Student.DateOfBirth;
            txtPhoneNumber.Text = Student.PhoneNumber;
            txtWhatsAppNumber.Text = Student.WhatsAppNumber;
            txtFatherName.Text = Student.FatherName;
            txtFatherNumber.Text = Student.FatherNumber;
            
            if (Student.StudentsStatus == "أعزب")
            {
                cmbStudentStatus.SelectedItem = "أعزب";
            }

            else
            {
                cmbStudentStatus.SelectedItem = "متزوج";
            }

            txtCity.Text = Student.City;
            cmbMajor.SelectedItem = cmbMajor.Items[Student.MajorID - 1];
            cmbUniversity.SelectedItem = cmbUniversity.Items[Student.UniversityID - 1];
            cmbLevels.SelectedItem = cmbLevels.Items[Student.LevelID - 1];
            cmbPeriods.SelectedItem = cmbPeriods.Items[Student.PeriodID - 1];
            picPersonalImage.Image = Image.FromFile(@Student.PersonalImage);
            picProofImage.Image = Image.FromFile(Student.ProofImage);
            picCardImage.Image = Image.FromFile(Student.CardImage);
            picFormImage.Image = Image.FromFile(Student.FormImage);
        }

        private bool  _CheckFromImageChoosen()
        {
            return (personalImage == "" || ProofImage == "" || CardImage == "" || FormImage == "");
        }

        void _CloseAllControls()
        {
           
            foreach(Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        bool _CheckFromAllTextBoxes()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    if (this.Controls[i].Text == "")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        bool CheckIfUserEnterAllTheInformation()
        {
            return _CheckFromImageChoosen() || _CheckFromAllTextBoxes();
        }

        void DischargeAllControlsInTheForm()
        {
            for (int i = 0; i < this.Controls.Count;i++)
            {
                if (this.Controls[i].GetType() == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    this.Controls[i].Text = "";
                }
            }

            picCardImage.Image = null;
            picPersonalImage.Image = null;
            picProofImage.Image = null;
            picFormImage.Image = null;
        }

        
        private void _LoadData()
        {
            FillAllComboBoxws();
            if (Mode == enMode.Add)
            {
                lbTitle.Text = "إضافة طالب";
                Student = new clsStudentsManagementBusiness();
                return;
            }

            Student = clsStudentsManagementBusiness.FindStudentByID(StudentID);

            if (Student == null)
            {
                MessageBox.Show("this Form Will Closed because no Student here :");
                this.Close();
                return;
            }

            setTheStudentInformationToControls();

            if (lbTitle.Text == "معلومات الطالب")
            {
                lbTitle.Text = "معلومات الطالب";
                this.Text = "معلومات الطالب";
                _CloseAllControls();
            }

            else
            {
                lbTitle.Text = "تعديل معلومات الطالب";
                this.Text = "تعديل معلومات الطالب";
            }
            
        }
        private void FrmAddNewStudent_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 600);
            //FillAllComboBoxws();
            
            _LoadData();
        }

        void ChooseImagesFunction(ref string imageName)
        {
            openFolderDialogSettings();

            if (ChooseImages.ShowDialog() == DialogResult.OK)
            {
                imageName = ChooseImages.FileName;
            }
        }

        private void btnPerosnalImage_Click(object sender, EventArgs e)
        {
            ChooseImagesFunction(ref personalImage);
            picPersonalImage.Image = Image.FromFile(personalImage);
        }

        private void btnCardImage_Click(object sender, EventArgs e)
        {
            ChooseImagesFunction(ref CardImage);
            picCardImage.Image = Image.FromFile(CardImage);
        }

        private void btnProofImage_Click(object sender, EventArgs e)
        {
            ChooseImagesFunction(ref ProofImage);
            picProofImage.Image = Image.FromFile(ProofImage);
        }

        private void btnFormImage_Click(object sender, EventArgs e)
        {
            ChooseImagesFunction(ref FormImage);
            picFormImage.Image = Image.FromFile(FormImage);
        }

        void SaveTheStudentsInformation()
        {
            Student.FullName = txtFullName.Text;
            Student.DateOfBirth = (DateTime)DateOfBirth.Value;
            Student.PhoneNumber = txtPhoneNumber.Text;
            Student.WhatsAppNumber = txtWhatsAppNumber.Text;
            Student.FatherName = txtFatherName.Text;
            Student.FatherNumber = txtFatherNumber.Text;
            Student.City = txtCity.Text;
            Student.StudentsStatus = cmbStudentStatus.SelectedItem.ToString();
            Student.MajorID = cmbMajor.SelectedIndex + 1;
            Student.UniversityID = cmbUniversity.SelectedIndex + 1;
            Student.LevelID = cmbLevels.SelectedIndex + 1;
            Student.PeriodID = cmbPeriods.SelectedIndex + 1;
            Student.EnteringDate = DateTime.Now;
            Student.StudentState = "منتظم";
            Student.PersonalImage = personalImage;
            Student.ProofImage = ProofImage;
            Student.FormImage = FormImage;
            Student.CardImage = CardImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckIfUserEnterAllTheInformation())
            {
                MessageBox.Show("Please Enter Full Information", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                SaveTheStudentsInformation();
            }

            if (Student.Save())
            {
                MessageBox.Show("The Student Adding Successfuly :-)","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("The Data Falid :-(");
            }

            Mode = enMode.Update;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DischargeAllControlsInTheForm();
        }
    }
}
