using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using StudentsManagementBusinessLayer;

namespace StudentsManagmentProject
{
    public partial class UsStatisticsManagment : UserControl
    {
        public UsStatisticsManagment()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        string Name = "";
        double perc = 0;
        int count = 1;
        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void UsStatisticsManagment_Load(object sender, EventArgs e)
        {
            

            dt = ClsViolationDetailesBusiness.GetViolationStatistics();
            chart1.DataSource = dt;

            

            foreach(DataRow dr in dt.Rows)
            {
                Name = dr["Name"].ToString();
                
                
                if (dr["perc"] == DBNull.Value)
                {
                    perc = 0;
                }

                else
                {
                    perc = Convert.ToInt32(dr["perc"]);
                }

                chart1.Series["Series1"].Points.AddXY(Name, 0);
            }

            chart1.Titles.Add("statisics");
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Name = dt.Rows[i][0].ToString();


                if (dt.Rows[i][1] == DBNull.Value)
                {
                    perc = 0;
                }

                
                if (dt.Rows[i][0] != DBNull.Value && double.TryParse(dt.Rows[i][1].ToString(), out double num))
                {
                    if (num > count)
                    {
                        double n = chart1.Series["Series1"].Points[i].YValues[0];
                        chart1.Series["Series1"].Points[i].YValues[0] = count;
                        chart1.Invalidate();
                        chart1.Update();
                        chart1.ChartAreas[0].RecalculateAxesScale();
                    }

                    
                }

                
            }
            count++;
        }
    }
}
