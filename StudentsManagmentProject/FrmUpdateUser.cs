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
    public partial class FrmUpdateUser : Form
    {
        public int permission = 0;
        public int ID { get; set; }
        public FrmUpdateUser(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        void UpdateUserPermission(int permission)
        {
            for(int i = 0; i < chkPermissionListBox.Items.Count;i++)
            {
                
                if ((permission & 1) == 1)
                {
                    chkPermissionListBox.SetItemChecked(0, true);
                }

                if ((permission & 2) == 2)
                {
                    chkPermissionListBox.SetItemChecked(1, true);
                }

                if ((permission & 4) == 4)
                {
                    chkPermissionListBox.SetItemChecked(2, true);
                }

                if ((permission & 8) == 8)
                {
                    chkPermissionListBox.SetItemChecked(3, true);
                }

                if ((permission & 16) == 16)
                {
                    chkPermissionListBox.SetItemChecked(4, true);
                }

                if ((permission & 32) == 32)
                {
                    chkPermissionListBox.SetItemChecked(5, true);
                }
            }

        }
        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            clsUsersBusiness user = clsUsersBusiness.FindUserByID(ID);
            if(user != null)
            {
                txtCurrentUserName.Text = user.UserName;
                txtCurrentPassword.Text = user.PassWord;
                UpdateUserPermission(user.Permission);
            }
        }

        public int CalculateThePermission()
        {
            if (chkPermissionListBox.CheckedItems.Contains(chkPermissionListBox.Items[0]))
            {
                permission += 1;
            }

            if (chkPermissionListBox.CheckedItems.Contains(chkPermissionListBox.Items[1]))
            {
                permission += 2;
            }

            if (chkPermissionListBox.CheckedItems.Contains(chkPermissionListBox.Items[2]))
            {
                permission += 4;
            }

            if (chkPermissionListBox.CheckedItems.Contains(chkPermissionListBox.Items[3]))
            {
                permission += 8;
            }

            if (chkPermissionListBox.CheckedItems.Contains(chkPermissionListBox.Items[4]))
            {
                permission += 16;
            }

            if (chkPermissionListBox.CheckedItems.Contains(chkPermissionListBox.Items[5]))
            {
                permission += 32;
            }

            return permission;
        }

        void clearTextBoxes()
        {
            txtNewUserName.Text = "";
            txtNewPassword.Text = "";
        }
        public bool CheckFromUserNameOrPassWord()
        {
            if (txtNewUserName.Text != "" && txtNewPassword.Text != "")
            {
                int permisstion = clsUsersBusiness.FindByUserNameAndPassWord(txtNewUserName.Text, txtNewPassword.Text);

                if (permisstion == 10)
                {
                    MessageBox.Show("This PassWord is Already in the Ssystem");
                    clearTextBoxes();
                    return false;
                }

                if (permisstion == 11)
                {
                    MessageBox.Show("This UserName is Already in the Ssystem");
                    clearTextBoxes();
                    return false;
                }

                if (permisstion == 12)
                {
                    return true;
                }

                else
                {
                    MessageBox.Show("This UserName And PassWord are Already in the Ssystem");
                    clearTextBoxes();
                    return false;
                }
            }

            else
            {
                MessageBox.Show("please enter Coorrect Information ");
                clearTextBoxes();
                return false;
            }
        }
        private void btnChangeUserName_Click(object sender, EventArgs e)
        {
            FrmAddNewUser user = new FrmAddNewUser();

            if(CalculateThePermission() == 0)
            {
                MessageBox.Show("Please enter Apermission for this user", "Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }


            if (CheckFromUserNameOrPassWord())
            {
                if (MessageBox.Show("Are you shur to update this user","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if(clsUsersBusiness.UpdateUserInfo(ID,txtNewUserName.Text,txtNewPassword.Text,permission))
                    {
                        MessageBox.Show("Updating successfuly", "Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
