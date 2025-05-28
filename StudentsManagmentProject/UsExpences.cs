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
    public partial class UsExpences : UserControl
    {
        public UsExpences()
        {
            InitializeComponent();
        }

        int Year = 0;
        int Month = 0;

        void ExchangeTheDateGridView()
        {
            dgvAllBills.Columns[0].HeaderText = "الرقم";
            dgvAllBills.Columns[1].HeaderText = "اسم الصنف";
            dgvAllBills.Columns[2].HeaderText = "الكمية";
            dgvAllBills.Columns[3].HeaderText = "سعر الحبة";
            dgvAllBills.Columns[4].HeaderText = "اسم المشتري";
            dgvAllBills.Columns[5].HeaderText = "تاريخ الشراء";
            dgvAllBills.Columns[6].HeaderText = "الإجمـــــــــالي";

            dgvAllBills.Columns[0].Width = 50;
        }

        private void _LoadData(bool Filter=false)
        {
            DataTable AllBills = new DataTable();
            AllBills = clsExpencesBusiness.GetAllBilles();
            
            
            if (Filter)
            {
                DataView dvFilterBills = new DataView();
                dvFilterBills = AllBills.DefaultView;
                AllBills = clsExpencesBusiness.FilteringDataTable(Month, Year,AllBills);
            }

            if (AllBills.Rows.Count == 0)
            {
                AllBills = clsExpencesBusiness.GetDataTableWithJustColumns();
            }

            dgvAllBills.DataSource = AllBills;
            ExchangeTheDateGridView();
        }

        private void UsExpences_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedItem = cmbYear.Items[0];   
            _LoadData();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            FrmAddNewBill newBill = new FrmAddNewBill(-1, "إضافة فاتورة جديدة");
            newBill.ShowDialog();
            _LoadData();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            FrmAddNewBill UpdateBill = new FrmAddNewBill((int)dgvAllBills.CurrentRow.Cells[0].Value, "تعديل الفاتورة");
            UpdateBill.ShowDialog();
            _LoadData();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you shur for delete this Bill","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsExpencesBusiness.DeleteBill((int)dgvAllBills.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }

                else
                {
                    MessageBox.Show("Wrong Deleted");
                }
            }

            _LoadData();
        }

        void DatingFilternig()
        {
            Month = (int)MonthCount.Value;

            if (cmbYear.SelectedItem == cmbYear.Items[0])
            {
                Year = 0;
            }

            else
            {
                string year= (cmbYear.Text.ToString());
                Year = int.Parse(year);
            }

            _LoadData(true);
        }

        private void MonthCount_ValueChanged(object sender, EventArgs e)
        {
            //DatingFilternig();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DatingFilternig();
        }
    }
}
