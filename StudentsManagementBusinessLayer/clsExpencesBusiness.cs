using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StudentsManagementDataAccessLayer;

namespace StudentsManagementBusinessLayer
{
    public class clsExpencesBusiness
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public int Qauntity { get; set; }
        public double Price { get; set; }
        public string BuyingName { get; set; }
        public DateTime BuyingDate { get; set; }
        public double TotalPrice { get; set; }

        public enum enMode {Add=0,Update=1 };
        enMode Mode = enMode.Add;

        public clsExpencesBusiness()
        {
            this.ID = -1;
            this.CategoryName = "";
            this.Qauntity = -1;
            this.Price = -1;
            this.BuyingName = "";
            this.BuyingDate = DateTime.Now;
            this.TotalPrice = 0;
            this.Mode = enMode.Add;
        }

        public clsExpencesBusiness(int ID,string CategoryName,int Quantity,double Price,
                                   string BuyingName,DateTime BuyingDate,double TotalPrice)
        {

            this.ID = ID;
            this.CategoryName = CategoryName;
            this.Price = Price;
            this.Qauntity = Quantity;
            this.BuyingDate = BuyingDate;
            this.BuyingName = BuyingName;
            this.TotalPrice = TotalPrice;
            this.Mode = enMode.Update;
        }

        private bool _AddNewBill()
        {
            this.ID = clsEpencesDataAccess.AddNewBills(this.CategoryName, this.Qauntity, this.Price, this.BuyingName,
                                                    this.BuyingDate, this.TotalPrice);

            return this.ID != -1;
        }

        static public DataTable GetAllBilles()
        {
            return clsEpencesDataAccess.GetAllBilles();
        }

        static public clsExpencesBusiness FindByID(int ID)
        {
            string CategoryName = "";
            double Price = 0;
            double TotalPrice = 0;
            int Quantity = 0;
            string BuyerName = "";
            DateTime BuyingDate = DateTime.Now;

            if (clsEpencesDataAccess.GetBillByID(ID,ref CategoryName,ref Quantity,ref Price,ref BuyerName,ref BuyingDate,ref TotalPrice))
            {
                return new clsExpencesBusiness(ID, CategoryName, Quantity, Price, BuyerName, BuyingDate, TotalPrice);
            }

            else
            {
                return null;
            }
        }

        private bool _UpdateBill()
        {
            return clsEpencesDataAccess.UpdateBill(this.ID, this.CategoryName, this.Qauntity, this.Price, this.BuyingName, this.BuyingDate, this.TotalPrice);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if (_AddNewBill())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateBill();
            }

            return false;
        }

        static public bool DeleteBill(int ID)
        {
            return clsEpencesDataAccess.DeleteBill(ID);
        }

        static public DataTable FilteringDataTable(int Month,int Year,DataTable dt)
        {
            /*DataTable Temp = new DataTable();
            GetHeaders(ref Temp);

            foreach(DataRow row in dt.Rows)
            {
                DateTime date = (DateTime)row["BuyingDate"];

                if (Year != 0 && Month != 0)
                {
                    if ((int)date.Day == Month && (int)date.Year == Year)
                    {
                        Temp.Rows.Add(row);
                    }
                }

                else if (Year != 0)
                {
                    if ((int)date.Year == Year)
                    {
                        Temp.Rows.Add(row);
                    }
                }

                else if(Month != 0)
                {
                    if ((int)date.Day == Month)
                    {
                        Temp.Rows.Add(row);
                    }
                }
            }

            return Temp;*/

            return clsEpencesDataAccess.GetAllBillesFilter(Year, Month);
        }

        static private void GetHeaders(ref DataTable tempDt)
        {
            tempDt.Columns.Add("الرقم", typeof(int));
            tempDt.Columns.Add("اسم الصنف", typeof(string));
            tempDt.Columns.Add("الكمية", typeof(int));
            tempDt.Columns.Add("سعر الحبة", typeof(double));
            tempDt.Columns.Add("اسم المشتري", typeof(string));
            tempDt.Columns.Add("تاريخ الشراء", typeof(DateTime));
            tempDt.Columns.Add("الإجمــــــالي", typeof(double));
        }

        static public DataTable GetDataTableWithJustColumns()
        {
            DataTable tempDt = new DataTable();

            GetHeaders(ref tempDt);

            tempDt.Rows.Add(0, "", null, null, "", null, null);

            return tempDt;
        }
    }
}
