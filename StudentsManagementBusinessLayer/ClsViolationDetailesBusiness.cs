using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementDataAccessLayer;
using System.Data;

namespace StudentsManagementBusinessLayer
{
    public class ClsViolationDetailesBusiness
    {
        public enum _enMode { AddMode=1,UpdateMode};
        public int _ViolationDetailesID { get; set; }
        public string _StudentName { get; set; }
        public int _StudentID { get; set; }
        public int _ViolationID { get; set; }
        public string _ViolationName { get; set; }
        public DateTime _ViolationDate { get; set; }
        public string _ViolationDescription { get; set; }
        public int _CountOfViolations { get; set; }

        public _enMode _Mode { get; set; }
        public ClsViolationDetailesBusiness()
        {
            _ViolationDetailesID =  -1;
            _StudentName = "";
            _ViolationName = "";
            _ViolationDate = DateTime.Now;
            _ViolationDescription = "";
            _Mode = _enMode.AddMode;
            _CountOfViolations = 0;
            _StudentID = 0;
            _ViolationID = 0;
        }

        public ClsViolationDetailesBusiness(int ViolationDeatailesID,string StudentName,
                        string ViolationName,DateTime ViolationDate,string ViolationDescription,int CountOfViolations)
        {
            _ViolationDetailesID = ViolationDeatailesID;
            _StudentName = StudentName;
            _ViolationName = ViolationName;
            _ViolationDate = ViolationDate;
            _ViolationDescription = ViolationDescription;
            _CountOfViolations = CountOfViolations;
            _Mode = _enMode.UpdateMode;
        }

        bool _AddNewViolationDetailes()
        {
            this._ViolationDetailesID = clsViolationsDetailsDataAccess.AddNewViolationsDetails(this._StudentID,
                this._ViolationID, this._ViolationDate, this._ViolationDescription);

            return this._ViolationDetailesID != -1;
        }

        bool _UpdateViolationDetailes()
        {
            return clsViolationsDetailsDataAccess.UpdateViolationsDetails(this._ViolationDetailesID,
                this._StudentID, this._ViolationID, this._ViolationDate, this._ViolationDescription);
        }

        static public ClsViolationDetailesBusiness FindByID(int ID)
        {
            string StudentName = "";
            string ViolationName = "";
            DateTime ViolationDate = DateTime.Now;
            string ViolationDescription = "";
            int CountOfViolations = 0;

            if(clsViolationsDetailsDataAccess.GetViolationsDetailesByID(ID,ref StudentName,
                                ref ViolationName,ref ViolationDate,ref ViolationDescription,ref CountOfViolations))
            {

                return new ClsViolationDetailesBusiness(ID, StudentName, ViolationName, ViolationDate, ViolationDescription,CountOfViolations);
            }

            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddMode:

                    _Mode = _enMode.UpdateMode;
                    return (_AddNewViolationDetailes());

                case _enMode.UpdateMode:

                    return _UpdateViolationDetailes();
            }

            return false;
        }

        static public DataTable GetViolationsDetailes(string Filter = "")
        {
            return clsViolationsDetailsDataAccess.GetViolationsDetails(Filter);
        }

        static public DataTable MakeEmptyTableForViolations()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("الرقم", typeof(int));
            dt.Columns.Add("إسم الطالب", typeof(string));
            dt.Columns.Add("نوع المخالفة", typeof(string));
            dt.Columns.Add("تاريخ المخالفة", typeof(DateTime));
            dt.Columns.Add("عدد المخالفات", typeof(int));

            dt.Rows.Add(null, "", "", null, null);

            return dt;
        }

        static public bool DeleteViolation(int ID)
        {
            return clsViolationsDetailsDataAccess.DeleteViolationDetails(ID);
        }

        static public DataTable GetFinalReport(string Filter = "")
        {
            return clsViolationsDetailsDataAccess.GetFinalReport(Filter);
        }

        static public DataTable MakeEmptyDataTableForFinalReport()
        {
            DataTable Final = new DataTable();

            Final.Columns.Add("الرقم", typeof(int));
            Final.Columns.Add("الاسم الكامل", typeof(string));
            Final.Columns.Add("مخالفات الصلاة", typeof(int));
            Final.Columns.Add("محالفات حلقات الفجر", typeof(int));
            Final.Columns.Add("مخالفات الأنشطة", typeof(int));
            Final.Columns.Add("مخالفات السلوك", typeof(int));
            Final.Columns.Add("مخالفات النظافة", typeof(int));
            Final.Columns.Add("مخالفة حلقة الاسبوع", typeof(int));
            Final.Columns.Add("النتيجة النهائية", typeof(int));

            Final.Rows.Add(null, "", null, null, null, null, null, null, null);

            return Final;
        }

        static public DataTable GetStudentViolationByName(string Name, string Filter = "")
        {
            return clsViolationsDetailsDataAccess.GetAllViolationsAboutTheStudentByItsName(Name , Filter);
        }

        static public DataTable MakeEmptyTableForFinalReportDetailes()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("نوع المخالفة", typeof(string));
            dt.Columns.Add("تاريخ المخالفة", typeof(DateTime));
            dt.Columns.Add("وصف المخالفة", typeof(string));
            dt.Columns.Add("إجمالي المخالفات", typeof(int));

            dt.Rows.Add("", null, "", null);

            return dt;
        }

        static public DataTable GetViolationStatistics()
        {
            return clsViolationsDetailsDataAccess.GetViolationStatistics();
        }
    }
}
