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
    public partial class UsUsersManagment : UserControl
    {
        public UsUsersManagment()
        {
            InitializeComponent();
        }

        void ChangeTheDataGridView ()
        {
            dgvAllUsers.Columns[0].HeaderText = "الرقم";
            dgvAllUsers.Columns[1].HeaderText = "اسم المستخدم";
            dgvAllUsers.Columns[2].HeaderText = "كلمة المرور";
            dgvAllUsers.Columns[3].HeaderText = "إدارة الطلاب";
            dgvAllUsers.Columns[4].HeaderText = "إدارةالأنشطة ";
            dgvAllUsers.Columns[5].HeaderText = "إدارة المصروفات";
            dgvAllUsers.Columns[6].HeaderText = "إدارة المخالفات";
            dgvAllUsers.Columns[7].HeaderText = "إدارة الموظفين";
            dgvAllUsers.Columns[8].HeaderText = "إدارة الحسابات";

            dgvAllUsers.Columns[0].Width = 50;
        }

        void _LoadData(string Filter = "")
        {
            DataTable dt = new DataTable();
            dt = clsUsersBusiness.GetAllUsers(Filter);
            dgvAllUsers.DataSource = dt;
            ChangeTheDataGridView();
        }

        private void UsUsersManagment_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnUpdateuser_Click(object sender, EventArgs e)
        {
            FrmUpdateUser frmUpdateUser = new FrmUpdateUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frmUpdateUser.ShowDialog();
            _LoadData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddNewUser NewUser = new FrmAddNewUser();
            NewUser.ShowDialog();
            _LoadData();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shre to delete this user ","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsUsersBusiness.DeleteUser((int)dgvAllUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfuly :-)","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _LoadData();
                }

                else
                {
                    MessageBox.Show("User Deleted not Successfuly :-)","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string Filter = $" where UserName like '{txtSearch.Text}%'";
                _LoadData(Filter);
            }

            else
            {
                _LoadData();
            }
        }
    }
}
