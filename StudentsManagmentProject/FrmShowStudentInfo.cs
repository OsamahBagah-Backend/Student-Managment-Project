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
    public partial class FrmShowStudentInfo : Form
    {
        public FrmShowStudentInfo()
        {
            InitializeComponent();
        }

        private void FrmShowStudentInfo_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 600);

            //chart1.DataSource = ClsViolationDetailesBusiness.
        }
    }
}
