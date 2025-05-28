using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentsManagementDataAccessLayer
{
    public class clsViolationsDetailsDataAccess
    {
        static private int ID { get; set; }

        static private int _GetLastID()
        {
            int lastID = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select max(ID) from ViolationsDetails";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null)
                {
                    lastID = Convert.ToInt32(result);
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

            return lastID;
        }

        clsViolationsDetailsDataAccess()
        {
            ID = _GetLastID();
        }

        static public DataTable GetViolationsDetails(string Filter = "")
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select ViolationsDetails.ID,Students.FullName,Violations.Name, " +
                           "ViolationsDetails.ViolationDate, " +
                           "R1.CountOfViolation " +
                           "from ViolationsDetails inner join Students " +
                           "on ViolationsDetails.StudentID = Students.ID " +
                           "inner join Violations on ViolationsDetails.ViolationID = Violations.ID " +
                           "inner join(select Students.FullName, Violations.Name, COUNT(*) as CountOfViolation " +
                           "from ViolationsDetails inner join Students " +
                           "on ViolationsDetails.StudentID = Students.ID " +
                           "inner " +
                           "join Violations on ViolationsDetails.ViolationID = Violations.ID " +
                           "group by FullName,Name) as R1 on Students.FullName = R1.FullName and Violations.Name = R1.Name ";

            if (Filter != "")
            {
                Query += Filter;
            }

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

        static public int AddNewViolationsDetails(int StudentID,int ViolationID,DateTime 
                                   ViolationDate,string ViolationDescription)
        {
            ID = _GetLastID();
            ID++;
            int _ViolationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "insert into ViolationsDetails " +
                          "values (@ID,@StudentID,@ViolationID,@ViolationDate,@ViolationDescription)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@StudentID", StudentID);
            Command.Parameters.AddWithValue("@ViolationID", ViolationID);
            Command.Parameters.AddWithValue("@ViolationDate", ViolationDate);
            Command.Parameters.AddWithValue("@ViolationDescription", ViolationDescription);

            try
            {
                Connection.Open();

                object result = Command.ExecuteNonQuery();

                if (result != null)
                {
                    _ViolationID = ID;
                }

                else
                {
                    _ViolationID = -1;
                }
            }

            catch(Exception message)
            {
                ViolationID = -1;
            }

            finally
            {
                Connection.Close();
            }

            return _ViolationID;
        }

        static public bool UpdateViolationsDetails(int ID,int StudentID,int ViolationID,
                                      DateTime ViolationDate,string ViolationDetaile)
        {
            int RowAffected = 0;

            SqlConnection Connectio = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "update ViolationsDetails set StudentID = @StudentID , " +
                                                        "ViolationID = @ViolationID, " +
                                                        "ViolationDate = @ViolationDate, " +
                                                        "ViolationDescription = @ViolationDetailes " +
                                                        "where ID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connectio);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@StudentID", StudentID);
            Command.Parameters.AddWithValue("@ViolationID", ViolationID);
            Command.Parameters.AddWithValue("@ViolationDate", ViolationDate);
            Command.Parameters.AddWithValue("@ViolationDetailes", ViolationDetaile);

            try
            {
                Connectio.Open();

                RowAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connectio.Close();
            }

            return RowAffected > 0;
        }

        static private bool _UpdateIDColumnsForAllRecords(int ViolationID)
        {
            int rowAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "update ViolationsDetails set ID = (ID - 1) where ID > @ViolationID ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ViolationID", ViolationID);

            try
            {
                Connection.Open();

                rowAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return rowAffected > 0;
        }

        static public bool DeleteViolationDetails(int ViolationID)
        {
            ID = _GetLastID();

            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "delete from ViolationsDetails where ID = @ViolationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ViolationID", ViolationID);

            try
            {
                Connection.Open();

                RowAffected = Command.ExecuteNonQuery();

                if (RowAffected != 0 && ViolationID != ID)
                {
                    _UpdateIDColumnsForAllRecords(ViolationID);
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

            return RowAffected>0;
        }

        static public bool GetViolationsDetailesByID(int ViolationDetailesID , ref string StudentName,
                       ref string ViolationName,ref DateTime ViolationDate,ref string ViolationDescription,
                       ref int CountOfViolation)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select Students.FullName,Violations.Name, " +
                           "ViolationsDetails.ViolationDate,ViolationsDetails.ViolationDescription, " +
                           "R1.CountOfViolation " +
                           "from ViolationsDetails inner join Students " +
                           "on ViolationsDetails.StudentID = Students.ID " +
                           "inner join Violations on ViolationsDetails.ViolationID = Violations.ID " +
                           "inner join(select Students.FullName, Violations.Name, COUNT(*) as CountOfViolation " +
                           "from ViolationsDetails inner join Students " +
                           "on ViolationsDetails.StudentID = Students.ID " +
                           "inner " +
                           "join Violations on ViolationsDetails.ViolationID = Violations.ID " +
                           "group by FullName,Name) as R1 on Students.FullName = R1.FullName and Violations.Name = R1.Name " +
                           " where ViolationsDetails.ID = @ID ";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ViolationDetailesID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    StudentName = (string)Reader["FullName"];
                    ViolationName = (string)Reader["Name"];
                    ViolationDate = (DateTime)Reader["ViolationDate"];
                    ViolationDescription = (string)Reader["ViolationDescription"];
                    CountOfViolation = (int)Reader["CountOfViolation"];
                }
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

        static public DataTable GetAllViolationsAboutTheStudentByItsName(string StudentName ,string Filter = "")
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select  Violations.Name, " +
                           "ViolationsDetails.ViolationDate,ViolationsDetails.ViolationDescription, " +
                           "R1.CountOfViolation " +
                           "from ViolationsDetails inner join Students " +
                           "on ViolationsDetails.StudentID = Students.ID " +
                           "inner join Violations on ViolationsDetails.ViolationID = Violations.ID " +
                           "inner join(select Students.FullName, Violations.Name, COUNT(*) as CountOfViolation " +
                           "from ViolationsDetails inner join Students " +
                           "on ViolationsDetails.StudentID = Students.ID " +
                           "inner " +
                           "join Violations on ViolationsDetails.ViolationID = Violations.ID " +
                           "group by FullName,Name) as R1 on Students.FullName = R1.FullName and Violations.Name = R1.Name " +
                           " where Students.FullName = @StudentName ";
             
            if (Filter != "")
            {
                Query += Filter;
            }

            DataTable StudentViolationsDataTable = new DataTable();

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentName", StudentName);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    StudentViolationsDataTable.Load(Reader);
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

            return StudentViolationsDataTable;
        }

        static public DataTable GetFinalReport(string Filter = "")
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable Report = new DataTable();

            string Query = "select * from FinalReport";

            if (Filter != "")
            {
                Query += Filter;
            }

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Report.Load(Reader);
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

            return Report;
        }

        static public DataTable GetViolationStatistics()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable dt =  new DataTable();

            string Query = "select Violations.Name,R3.perc " +
                           "from Violations left join " +

                           "(select Name, TotalViolations, " +
                           "perc = (cast(TotalViolations as float) / cast(TotalAllViolations as float) * 100) " +
                           "from(select Name, Count(CountOfViolation) as TotalViolations, " +
                           "(select count(*) from ViolationsDetails) as TotalAllViolations " +
                           "from FullInformationAboutViolations " +
                           "group by Name)R1 ) as R3 " +
                           "on Violations.Name = R3.Name order by Name desc ";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close ();
            }

            catch (Exception ex)
            {
                //ex
            }

            finally
            {
                Connection.Close();
            }

            return dt;
        }
    }
}
