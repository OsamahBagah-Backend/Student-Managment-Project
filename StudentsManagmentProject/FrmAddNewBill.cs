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
    public partial class FrmAddNewBill : Form
    {
        enum enMode { Add = 0, Update = 1 };
        enMode Mode = enMode.Add;
        int BillID;

        clsExpencesBusiness Bill;
        public FrmAddNewBill(int ID,string TitleName)
        {
            InitializeComponent();

            if (ID != -1)
            {
                this.Mode = enMode.Update;
                this.BillID = ID;
            }

            else
            {
                this.Mode = enMode.Add;
            }

            this.Text = TitleName;
        }

        private void FrmAddNewBill_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        void SetTheContrlosValue()
        {
            txtCategoryName.Text = Bill.CategoryName;
            txtPriceOne.Text = (Bill.Price).ToString();
            txtTotalPrice.Text = (Bill.TotalPrice).ToString();
            txtBuyingName.Text = (Bill.BuyingName).ToString();
            BuyingDate.Value = Bill.BuyingDate;
            QuantityNumber.Value = Bill.Qauntity;
        }

        void _LoadData()
        {
            if (Mode == enMode.Add)
            {
                this.Text = "إضافة فاتورة";
                Bill = new clsExpencesBusiness();
                return;
            }

            Bill = clsExpencesBusiness.FindByID(this.BillID);

            if (Bill == null)
            {
                MessageBox.Show("this form will closed beacause no Information :-(");
                this.Close();
                return;
            }

            SetTheContrlosValue();
            this.Text = "تعديل الفاتورة";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bill.CategoryName = txtCategoryName.Text;
            Bill.Price = double.Parse(txtPriceOne.Text.ToString());
            Bill.TotalPrice = double.Parse(txtTotalPrice.Text.ToString());
            Bill.BuyingName = txtBuyingName.Text;
            Bill.BuyingDate = (DateTime)BuyingDate.Value;
            Bill.Qauntity = (int)QuantityNumber.Value;

            if (Bill.Save())
            {
                MessageBox.Show("Data Saved Successsfuly :-)", "Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Data Saved Successfuly :-(", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            Mode = enMode.Update;
        }

        private void txtPriceOne_TextChanged(object sender, EventArgs e)
        {
            if ((txtPriceOne.Text != "" && txtPriceOne.Text !="0") && QuantityNumber.Value != 0)
            {
                txtTotalPrice.Text = (int.Parse(txtPriceOne.Text) * QuantityNumber.Value).ToString();
            }

            else
            {
                txtTotalPrice.Text = "";
            }
        }
    }
}
