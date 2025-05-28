using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagmentProject
{
    public partial class FrmMainInterface : Form
    {
        int _permission;

        void changeTheButtonColorAndEnabled(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.Enabled = false;
        }

        void ChangeButtonImageAndColors(Guna.UI2.WinForms.Guna2Button btn)
        {
            if (btn.Name == btnHomeBage.Name)
            {
                btnHomeBage.FillColor = Color.White;
                btnHomeBage.ForeColor = Color.FromArgb(0,30, 60, 90);
                btnHomeBage.Image = Properties.Resources.hom1;
            }

            else
            {
                btnHomeBage.FillColor = Color.FromArgb(30, 60, 90);
                btnHomeBage.ForeColor = Color.White;
                btnHomeBage.Image = Properties.Resources.house_2_4x;
            }

            if(btn.Name == btnStudentInformation.Name)
            {
                btnStudentInformation.FillColor = Color.White;
                btnStudentInformation.ForeColor = Color.FromArgb(30, 60, 90);
                btnStudentInformation.Image = Properties.Resources.users_4x;
            }

            else
            {
                btnStudentInformation.FillColor = Color.FromArgb(30, 60, 90);
                btnStudentInformation.ForeColor = Color.White;
                btnStudentInformation.Image = Properties.Resources.ue1;
            }

            if (btn.Name == btnBledgeManagment.Name)
            {
                btnBledgeManagment.FillColor = Color.White;
                btnBledgeManagment.ForeColor = Color.FromArgb(30, 60, 90);
                btnBledgeManagment.Image = Properties.Resources._٢٠٢٤١١١٢_٠٩٥٩٣٠;
            }

            else
            {
                btnBledgeManagment.FillColor = Color.FromArgb(30, 60, 90);
                btnBledgeManagment.ForeColor = Color.White;
                btnBledgeManagment.Image = Properties.Resources._٢٠٢٤١١١٢_٠٩٥٩٠٩;
            }

            if (btn.Name == btnActivitesManagment.Name)
            {
                btnActivitesManagment.FillColor = Color.White;
                btnActivitesManagment.ForeColor = Color.FromArgb(30, 60, 90);
                btnActivitesManagment.Image = Properties.Resources._٢٠٢٤١١٢٣_١٤٠٥٥٨;
            }

            else
            {
                btnActivitesManagment.FillColor = Color.FromArgb(30, 60, 90);
                btnActivitesManagment.ForeColor = Color.White;
                btnActivitesManagment.Image = Properties.Resources._٢٠٢٤١١٢٣_١٤٠٤٣٨;
            }

            if(btn.Name == btnExpenses.Name)
            {
                btnExpenses.FillColor = Color.White;
                btnExpenses.ForeColor = Color.FromArgb(30, 60, 90);
                btnExpenses.Image = Properties.Resources.wsq1;
            }

            else
            {
                btnExpenses.FillColor = Color.FromArgb(30, 60, 90);
                btnExpenses.ForeColor = Color.White;
                btnExpenses.Image = Properties.Resources.food_svgrepo_com;
            }

            if (btn.Name == btnEmployeeManagment.Name)
            {
                btnEmployeeManagment.FillColor = Color.White;
                btnEmployeeManagment.ForeColor = Color.FromArgb(30, 60, 90);
                btnEmployeeManagment.Image = Properties.Resources._٢٠٢٤١١١٢_١٠٠٦٢٣;
            }

            else
            {
                btnEmployeeManagment.FillColor = Color.FromArgb(30, 60, 90);
                btnEmployeeManagment.ForeColor = Color.White;
                btnEmployeeManagment.Image = Properties.Resources._٢٠٢٤١١١٢_١٠٠٦٠٨;
            }

            if (btn.Name == btnUsersManagment.Name)
            {
                btnUsersManagment.FillColor = Color.White;
                btnUsersManagment.ForeColor = Color.FromArgb(30, 60, 90);
                btnUsersManagment.Image = Properties.Resources.user_laptop_4x;
            }

            else
            {
                btnUsersManagment.FillColor = Color.FromArgb(30, 60, 90);
                btnUsersManagment.ForeColor = Color.White;
                btnUsersManagment.Image = Properties.Resources.e1;
            }

            if (btn.Name == btnAboutProgrammers.Name)
            {
                btnAboutProgrammers.FillColor = Color.White;
                btnAboutProgrammers.ForeColor = Color.FromArgb(30, 60, 90);
                btnAboutProgrammers.Image = Properties.Resources._٢٠٢٤١١١٢_١٠٠٣١٣;
            }

            else
            {
                btnAboutProgrammers.FillColor = Color.FromArgb(30, 60, 90);
                btnAboutProgrammers.ForeColor = Color.White;
                btnAboutProgrammers.Image = Properties.Resources._٢٠٢٤١١١٢_١٠٠٣٠٣;
            }
        }

        void SetThePermissionToTheUser(int Permission)
        {
            if ((Permission & 1) != 1)
            {
                changeTheButtonColorAndEnabled(btnStudentInformation);
            }

            if ((Permission & 2) != 2)
            {
                changeTheButtonColorAndEnabled(btnActivitesManagment);
            }

            if ((Permission & 4) != 4)
            {
                changeTheButtonColorAndEnabled(btnExpenses);
            }

            if ((Permission & 8) != 8)
            {
                changeTheButtonColorAndEnabled(btnBledgeManagment);
            }

            if ((Permission & 16) != 16)
            {
                changeTheButtonColorAndEnabled(btnEmployeeManagment);
            }

            if ((Permission & 32) != 32)
            {
                changeTheButtonColorAndEnabled(btnUsersManagment);
            }
        }

        public FrmMainInterface(int permission)
        {
            InitializeComponent();
            _permission = permission;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 660);
            InformationMenue.Height = 667;
            //usMainBage1.BringToFront();
            SetThePermissionToTheUser(_permission);
            clsUserControlManagment.Initialize(pnContainAllUserControls);
            clsUserControlManagment.ShowUserControl(new UsMainBage());
            ChangeButtonImageAndColors(btnHomeBage);
        }

        private void btnHomeBage_Click_1(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsMainBage());
            ChangeButtonImageAndColors(btnHomeBage);
        }

        private void btnStudentInformation_Click_1(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsStudentsInformations());
            ChangeButtonImageAndColors(btnStudentInformation);
        }

        private void btnExpenses_Click_1(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsExpences());
            ChangeButtonImageAndColors(btnExpenses);
        }

        private void btnUsersManagment_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsUsersManagment());
            ChangeButtonImageAndColors(btnUsersManagment);
        }

        private void btnAboutProgrammers_Click_1(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsAboutUs());
            ChangeButtonImageAndColors(btnAboutProgrammers);
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBledgeManagment_Click(object sender, EventArgs e)
        {
            clsUserControlManagment.ShowUserControl(new UsViolationManagmenet());
            ChangeButtonImageAndColors(btnBledgeManagment);
        }

    }
}
