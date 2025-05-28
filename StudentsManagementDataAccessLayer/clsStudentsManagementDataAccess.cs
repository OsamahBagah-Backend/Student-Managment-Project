using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentsManagementDataAccessLayer
{
    public class clsStudentsManagementDataAccess
    {
        static public DataTable GetStudentsMenueInformation(string Filter)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Students.ID, Students.FullName, Students.PhoneNumber, Students.State, " +
                           "Levels.LevelName, Universities.UniversityName, Majors.MajorName, Piordes.PeriodName " +
                            "FROM Students INNER JOIN " +
                            "Levels ON Students.CurrentLevel = Levels.ID INNER JOIN " +
                            "Majors ON Students.Major = Majors.ID INNER JOIN " +
                            "Piordes ON Students.StudyPeriod = Piordes.ID INNER JOIN " +
                            "Universities ON Students.University = Universities.ID";

            if (Filter != "")
            {
                Query += Filter;
            }

            Query += " order by Students.ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public DataTable GetWhatTableYouWant(string TableName)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select *from " + TableName; //+ TableName;

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public bool GetStudentInfoByID(int StudentID,ref string FullName, ref DateTime  DateOfBirth,ref string PhoneNumber,ref string WhatsAppNumber,
                ref string FatherName,ref string FatherNumber,ref string City,ref string StudentStatus, ref int Major,
                ref int University,ref int Level,ref int Period, ref string PersonalImage,ref string ProofImage,
                ref string CardImage,ref string FormImage, ref DateTime EnteringDate,ref string StudentState)
        {

            bool IsFound = false;
            
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Students Where ID=@StudentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                //d.Load(Reader);
                if (Reader.Read())
                {
                    IsFound = true;
                    FullName = (string)Reader["FullName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    PhoneNumber = (string)Reader["PhoneNumber"];
                    WhatsAppNumber = (string)Reader["WhatsAppNumber"];
                    FatherName = (string)Reader["FatherName"];
                    FatherNumber = (string)Reader["FatherNumber"];
                    City = (string)Reader["City"];
                    StudentStatus = (string)Reader["StudetnStatus"];
                    Major = (int)Reader["Major"];
                    University = (int)Reader["University"];
                    Level = (int)Reader["CurrentLevel"];
                    Period = (int)Reader["StudyPeriod"];
                    
                    if (Reader["PersonalImage"] == DBNull.Value)
                    {
                        PersonalImage = "";
                    }

                    else
                    {
                        PersonalImage = (string)Reader["PersonalImage"];
                    }

                    if (Reader["ProofImage"] == DBNull.Value)
                    {
                        ProofImage = "";
                    }

                    else
                    {
                        ProofImage = (string)Reader["ProofImage"];
                    }

                    if (Reader["CardImage"] == DBNull.Value)
                    {
                        CardImage = "";
                    }

                    else
                    {
                        CardImage = (string)Reader["CardImage"];
                    }

                    if (Reader["FormImage"] == DBNull.Value)
                    {
                        FormImage = "";
                    }

                    else
                    {
                        FormImage = (string)Reader["FormImage"];
                    }

                    EnteringDate = (DateTime)Reader["EnteringDate"];
                    StudentState = (string)Reader["State"];
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                IsFound = false;
            }

            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        static public int AddNewStuent(string FullName,DateTime DateOfBirth,string PhoneNumber,string WhatsAppNumber,
                        string FatherName,string FatherNumber,string City,string StudentStatus, int MajorID,int UniversityID,
                        int LevelID,int PeriodID,string PersonaImage,string ProofImage,string CardImage,string FormImage,
                        DateTime EnteringDate,string StudentState)
        {

            int StudentID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "insert into Students values (@FullName,@DateOfBirth,@PhoneNumber,@WhatsAppNumber,@FatherName," +
                           "@FatherNumber,@City,@StudentStatus,@MajorID,@UniversityID,@LevelID,@PeriodID,@PersonalImage,@ProofImage," +
                           "@CardImage,@FormImage,@EnteringDate,@StudentState); " +
                           "select SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FullName", FullName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            Command.Parameters.AddWithValue("@WhatsAppNumber", WhatsAppNumber);
            Command.Parameters.AddWithValue("@FatherName", FatherName);
            Command.Parameters.AddWithValue("@FatherNumber",FatherNumber);
            Command.Parameters.AddWithValue("@City", City);
            Command.Parameters.AddWithValue("@StudentStatus", StudentStatus);
            Command.Parameters.AddWithValue("@MajorID", MajorID);
            Command.Parameters.AddWithValue("@UniversityID", UniversityID);
            Command.Parameters.AddWithValue("@LevelID", LevelID);
            Command.Parameters.AddWithValue("@PeriodID", PeriodID);
            Command.Parameters.AddWithValue("@PersonalImage", PersonaImage);
            Command.Parameters.AddWithValue("@ProofImage", ProofImage);
            Command.Parameters.AddWithValue("@CardImage", CardImage);
            Command.Parameters.AddWithValue("@FormImage", FormImage);
            Command.Parameters.AddWithValue("@EnteringDate", EnteringDate);
            Command.Parameters.AddWithValue("@StudentState", StudentState);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int InstedID))
                {
                    StudentID = InstedID;
                }

            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return StudentID;
        }

        /*static public DataTable GetAllInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Students";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }*/

        static public bool UpdateStudentInformation(int ID,string FullName,DateTime DateOfBirth,string PhoneNumber,
                                                    string WhatsAppNumber,string FatherName,string FatherNumber,string City,
                                                    string StudentStatus,int MajorID,int UniversityID,int LevelID,int periodID,
                                                    string PersonalImage,string ProofImage,string CardImage,string FormImage)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            int rowAffected = 0;
            string Query = "update students set FullName = @FullName, " +
                                           "DateOfBirth=@DateOfBirth, " +
                                           "PhoneNumber=@PhoneNumber, " +
                                           "WhatsAppNumber=@WhatsAppNumber, " +
                                           "FatherName=@FatherName, " +
                                           "FatherNumber=@FatherNumber, " +
                                           "City=@City, " +
                                           "StudetnStatus=@StudentStatus, " +
                                           "Major=@MajorID, " +
                                           "University=@UniversityID, " +
                                           "Currentlevel=@LevelID, " +
                                           "StudyPeriod=@PeriodID, " +
                                           "PersonalImage=@PersonalImage, " +
                                           "ProofImage=@ProofImage, " +
                                           "CardImage=@CardImage, " +
                                           "FormImage=@FormImage " +
                                           "where ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@FullName", FullName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            Command.Parameters.AddWithValue("@WhatsAppNumber", WhatsAppNumber);
            Command.Parameters.AddWithValue("@FatherName", FatherName);
            Command.Parameters.AddWithValue("@FatherNumber", FatherNumber);
            Command.Parameters.AddWithValue("@City", City);
            Command.Parameters.AddWithValue("@StudentStatus", StudentStatus);
            Command.Parameters.AddWithValue("@MajorID", MajorID);
            Command.Parameters.AddWithValue("@UniversityID", UniversityID);
            Command.Parameters.AddWithValue("@LevelID", LevelID);
            Command.Parameters.AddWithValue("@PeriodID", periodID);
            Command.Parameters.AddWithValue("@PersonalImage", PersonalImage);
            Command.Parameters.AddWithValue("@ProofImage", ProofImage);
            Command.Parameters.AddWithValue("@CardImage", CardImage);
            Command.Parameters.AddWithValue("@FormImage", FormImage);

            try
            {
                Connection.Open();
                rowAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                return false;
            }

            finally
            {
                Connection.Close();
            }

            return (rowAffected > 0);
        }

        static public bool  DeleteStudent(int StudentID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete from Students where ID=@StudentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        static public int GetStudentIDByName(string Name)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int _ID = -1;

            string Query = "select ID from Students where FullName = @Name ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Name", Name);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    _ID = ID;
                }
            }

            catch(Exception ex)
            {
                _ID = -1;
            }

            finally
            {
                Connection.Close();
            }

            return _ID;
        }
    }
}
