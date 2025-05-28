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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        void ClearUserNameAndPasswordTextBoxes()
        {
            txtUserNameLog.Text = "";
            txtPasswordLog.Text = "";
        }

        void ValidationTheLoginError(string ErrorMessage)
        {
            MessageBox.Show(ErrorMessage, "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearUserNameAndPasswordTextBoxes();
        }

        void Login()
        {
            int permission = clsUsersBusiness.FindByUserNameAndPassWord(txtUserNameLog.Text, txtPasswordLog.Text);

            if (permission == -10)
            {
                ValidationTheLoginError("Wrong User Name Please try Again: -(");
                return;
            }

            else if (permission == -11)
            {
                ValidationTheLoginError("Wrong Password please try again :-(");
                return;
            }

            else if (permission == -12)
            {
                ValidationTheLoginError("the UserName And PassWord is Wrong try Again :-(");
                return;
            }

            else
            {
                
                FrmMainInterface FrmHomeBage = new FrmMainInterface(permission);
                FrmHomeBage.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();   
        }
    }
}
