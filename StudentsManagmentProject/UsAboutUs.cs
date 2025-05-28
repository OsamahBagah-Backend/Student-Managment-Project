using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagmentProject
{
    
    public partial class UsAboutUs : UserControl
    {
        public UsAboutUs()
        {
            InitializeComponent();
        }

        void ChangeButtonBackColorAndForeColor(Guna.UI2.WinForms.Guna2Button Button)
        {
            foreach(Guna.UI2.WinForms.Guna2Button btn in pnFooter.Controls)
            {
                if (btn.Name == Button.Name)
                {
                    btn.FillColor = Color.FromArgb(30, 60, 90);
                    btn.ForeColor = Color.White;
                }

                else
                {
                    btn.FillColor = Color.White;
                    btn.ForeColor = Color.FromArgb(30, 60, 90);
                }
            }
        }

        private void UsAboutUs_Load(object sender, EventArgs e)
        {
            usMe1.BringToFront();
            ChangeButtonBackColorAndForeColor(btnMe);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            usMe1.BringToFront();
            ChangeButtonBackColorAndForeColor(btnMe);
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            usMyTravel1.BringToFront();
            ChangeButtonBackColorAndForeColor(btnTravel);
        }

        private void btnGools_Click(object sender, EventArgs e)
        {
            usMyGools1.BringToFront();
            ChangeButtonBackColorAndForeColor(btnGools);
        }

        private void btnWhay_Click(object sender, EventArgs e)
        {
            usWhayProgramming1.BringToFront();
            ChangeButtonBackColorAndForeColor(btnWhay);
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            usMyProjects1.BringToFront();
            ChangeButtonBackColorAndForeColor(btnProjects);
        }
    }
}
