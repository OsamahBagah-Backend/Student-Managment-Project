using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StudentsManagementDataAccessLayer;

namespace StudentsManagementBusinessLayer
{
    public class clsStudentsManagementBusiness
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth {get;set; }
        public string PhoneNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string FatherName { get; set; }
        public string FatherNumber { get; set; }
        public string City { get; set; }
        public string StudentsStatus { get; set; }
        public int MajorID { get; set; }
        public int UniversityID { get; set; }
        public int LevelID { get; set; }
        public int PeriodID { get; set; }
        public string PersonalImage { get; set; }
        public string ProofImage { get; set; }
        public string CardImage { get; set; }
        public string FormImage { get; set; }
        public DateTime EnteringDate { get; set; }
        public string StudentState { get; set; }

        public enum enMode { Add=0,Update=1 };
        enMode Mode = enMode.Add;

        public clsStudentsManagementBusiness()
        {
            this.ID = -1;
            this.FullName = "";
            this.DateOfBirth = DateTime.Now;
            this.PhoneNumber = "";
            this.WhatsAppNumber = "";
            this.FatherName = "";
            this.FatherNumber = "";
            this.City = "";
            this.StudentsStatus = "";
            this.MajorID = -1;
            this.LevelID = -1;
            this.UniversityID = -1;
            this.PeriodID = -1;
            this.PersonalImage = "";
            this.ProofImage = "";
            this.CardImage = "";
            this.FormImage = "";
            this.EnteringDate = DateTime.Now;
            this.StudentState = "";
            Mode = enMode.Add;
        }

        public clsStudentsManagementBusiness(int ID,string FullName,DateTime DateOfBirth,string PhoneNumber,string WhatsAppNumber,
                string FatherName,string FatherNumber,string City,string StudentStatus, int Major,
                int University,int Level ,int Period , string PersonalImage,string ProofImage,
                string CardImage,string FormImage,DateTime EnteringDate,string StudentState)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.WhatsAppNumber = WhatsAppNumber;
            this.FatherName = FatherName;
            this.FatherNumber = FatherNumber;
            this.City = City;
            this.StudentsStatus = StudentStatus;
            this.MajorID = Major;
            this.LevelID = Level;
            this.UniversityID = University;
            this.PeriodID = Period;
            this.PersonalImage = PersonalImage;
            this.ProofImage = ProofImage;
            this.CardImage = CardImage;
            this.FormImage = FormImage;
            this.EnteringDate = EnteringDate;
            this.StudentState = StudentState;
            Mode = enMode.Update;
        }

        private bool _AddNewStudents()
        {
            this.ID = clsStudentsManagementDataAccess.AddNewStuent(this.FullName, this.DateOfBirth, PhoneNumber,
                                            this.WhatsAppNumber, this.FatherName, this.FatherNumber,
                                            this.City, this.StudentsStatus, this.MajorID, this.UniversityID, this.LevelID,
                                            this.PeriodID, this.PersonalImage, this.ProofImage, this.CardImage, this.FormImage,
                                            this.EnteringDate, this.StudentState);
            

            return this.ID != -1;
        }

        /*static private bool FillTheVariables(DataTable dt,int StudentID, ref string FullName, ref DateTime DateOfBirth, ref string PhoneNumber, ref string WhatsAppNumber,
                ref string FatherName, ref string FatherNumber, ref string City, ref string StudentStatus, ref int Major,
                ref int University, ref int Level, ref int Period, ref string PersonalImage, ref string ProofImage,
                ref string CardImage, ref string FormImage, ref DateTime EnteringDate, ref string StudentState)
        {

            bool IsFound = false;
            foreach(DataRow row in dt.Rows)
            {
                if ((int)row["ID"] == StudentID)
                {
                    IsFound = true;
                    FullName = (string)row["FullName"];
                    DateOfBirth = (DateTime)row["DateOfBirth"];
                    PhoneNumber = (string)row["PhoneNumber"];
                    WhatsAppNumber = (string)row["WhatsAppNumber"];
                    FatherName = (string)row["FatherName"];
                    FatherNumber = (string)row["FatherNumber"];
                    City = (string)row["City"];
                    StudentStatus = (string)row["StudetnStatus"];
                    Major = (int)row["Major"];
                    University = (int)row["University"];
                    Level = (int)row["CurrentLevel"];
                    Period = (int)row["StudyPeriod"];
                    PersonalImage = (string)row["PersonalImage"];
                    ProofImage = (string)row["ProofImage"];
                    CardImage = (string)row["CardImage"];
                    FormImage = (string)row["FormImage"];
                    EnteringDate = (DateTime)row["EnterigDate"];
                    StudentState = (string)row["State"];
                }
            }

            return IsFound;
        }*/

        public static clsStudentsManagementBusiness FindStudentByID(int ID)
        {
            string FullName = "";
            DateTime DateOfBirth = DateTime.Now;
            string PhoneNumber = "";
            string WhatsAppNumber = "";
            string FatherName = "";
            string FatherNumber = "";
            string City = "";
            string StudentsStatus = "";
            int MajorID = -1;
            int LevelID = -1;
            int UniversityID = -1;
            int PeriodID = -1;
            string PersonalImage = "";
            string ProofImage = "";
            string CardImage = "";
            string FormImage = "";
            DateTime EnteringDate = DateTime.Now;
            string StudentState = "";

            /*DataTable dt = clsStudentsManagementDataAccess.GetAllInfo();

            if (FillTheVariables(dt,ID, ref FullName, ref DateOfBirth, ref PhoneNumber,
                 ref WhatsAppNumber, ref FatherName, ref FatherNumber, ref City, ref StudentsStatus, ref MajorID, ref UniversityID,
                 ref LevelID, ref PeriodID, ref PersonalImage, ref ProofImage, ref CardImage, ref FormImage, ref EnteringDate, ref StudentState))
            {

                return new clsStudentsManagementBusiness(ID, FullName, DateOfBirth, PhoneNumber, WhatsAppNumber,
                           FatherName, FatherNumber, City, StudentsStatus, MajorID, UniversityID, LevelID, PeriodID,
                           PersonalImage, ProofImage, CardImage, FormImage, EnteringDate, StudentState);
            }

            else
            {
                return null;
            }*/

            if (clsStudentsManagementDataAccess.GetStudentInfoByID(ID,ref FullName,ref DateOfBirth,ref PhoneNumber,
                 ref WhatsAppNumber,ref FatherName,ref FatherNumber,ref City,ref StudentsStatus,ref MajorID,ref UniversityID,
                 ref LevelID,ref PeriodID,ref PersonalImage,ref ProofImage,ref CardImage,ref FormImage,ref EnteringDate,ref StudentState))
            {

                return new clsStudentsManagementBusiness(ID, FullName, DateOfBirth, PhoneNumber, WhatsAppNumber,
                           FatherName, FatherNumber, City, StudentsStatus, MajorID, UniversityID, LevelID, PeriodID,
                           PersonalImage, ProofImage, CardImage, FormImage, EnteringDate, StudentState);
            }

            else
            {
                return null;
            }
        }

        static public DataTable GetStudentsMenueInformation(string Filter)
        {
            return clsStudentsManagementDataAccess.GetStudentsMenueInformation(Filter);
        }

        static public DataTable GetWhatYouWantTableInformation(string TableName)
        {
            return clsStudentsManagementDataAccess.GetWhatTableYouWant(TableName);
        }

        static public DataTable MakeEmpityDataTable()
        {
            DataTable EmptyDataTable = new DataTable();

            EmptyDataTable.Columns.Add("الرقم", typeof(int));
            EmptyDataTable.Columns.Add("FullName", typeof(string));
            EmptyDataTable.Columns.Add("PhoneNumber", typeof(string));
            EmptyDataTable.Columns.Add("State", typeof(string));
            EmptyDataTable.Columns.Add("LevelName", typeof(string));
            EmptyDataTable.Columns.Add("UniversityName", typeof(string));
            EmptyDataTable.Columns.Add("MajorName", typeof(string));
            EmptyDataTable.Columns.Add("PeriodName", typeof(string));

            EmptyDataTable.Rows.Add(0,"", "", "", "", "", "", "");

            return EmptyDataTable;
        }

        private bool _UpdateStudentInfo()
        {
            return clsStudentsManagementDataAccess.UpdateStudentInformation(this.ID, this.FullName, this.DateOfBirth, PhoneNumber,
                        this.WhatsAppNumber, this.FatherName, this.FatherNumber,
                        this.City, this.StudentsStatus, this.MajorID, this.UniversityID, this.LevelID,
                        this.PeriodID, this.PersonalImage, this.ProofImage, this.CardImage, this.FormImage);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if (_AddNewStudents())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateStudentInfo();
         
            }

            return false;
        }

        static public bool DeleteStudent(int StudentID)
        {
            return clsStudentsManagementDataAccess.DeleteStudent(StudentID);
        }

        static public int GetStudentIDByName(string Name)
        {
            return clsStudentsManagementDataAccess.GetStudentIDByName(Name);
        }
    }
}
