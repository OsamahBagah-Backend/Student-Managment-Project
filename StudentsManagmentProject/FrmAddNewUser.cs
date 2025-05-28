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
    public partial class FrmAddNewUser : Form
    {
        int permission = 0;
        public FrmAddNewUser()
        {
            InitializeComponent();
        }

        void clearTextBoxes()
        {
            txtUserName.Text = "";
            txtPassWord.Text = "";
        }

        void ValidationAddTheUserError(string ErrorMessage)
        {
            MessageBox.Show(ErrorMessage,"Worng",MessageBoxButtons.OK,MessageBoxIcon.Error);
            clearTextBoxes();
        }

        public bool CheckFromUserNameOrPassWord()
        {
            if (txtUserName.Text != "" && txtPassWord.Text !="")
            {
                int permisstion = clsUsersBusiness.FindByUserNameAndPassWord(txtUserName.Text, txtPassWord.Text);

                if (permisstion == -10)
                {
                    ValidationAddTheUserError("This PassWord is Already in the Ssystem");
                    return false;
                }

                if (permisstion == -11)
                {
                    ValidationAddTheUserError("This UserName is Already in the Ssystem");
                    return false;
                }

                if (permisstion == -12)
                {
                    return true;
                }

                else
                {
                    ValidationAddTheUserError("This UserName And PassWord are Already in the Ssystem");
                    return false;
                }
            }

            else
            {
                ValidationAddTheUserError("Please fill All The Text Boxes");

                return false;
            }
        }

        public int CalculateThePermission()
        {
            if(permissionList.CheckedItems.Contains(permissionList.Items[0]))
            {
                permission += 1;
            }

            if (permissionList.CheckedItems.Contains(permissionList.Items[1]))
            {
                permission += 2;
            }

            if (permissionList.CheckedItems.Contains(permissionList.Items[2]))
            {
                permission += 4;
            }

            if (permissionList.CheckedItems.Contains(permissionList.Items[3]))
            {
                permission += 8;
            }

            if (permissionList.CheckedItems.Contains(permissionList.Items[4]))
            {
                permission += 16;
            }

            if (permissionList.CheckedItems.Contains(permissionList.Items[5]))
            {
                permission += 32;
            }

            return permission;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if(CalculateThePermission() == 0)
            {
                MessageBox.Show("please enter permission for this user","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (CheckFromUserNameOrPassWord())
            {
                if(clsUsersBusiness.AddNewUser(txtUserName.Text, txtPassWord.Text,permission))
                {
                    MessageBox.Show("the User Is Added Successfuly :-)","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("the User Is not Added :-(");
                }
                
                return;
            }

        }

    }
}
