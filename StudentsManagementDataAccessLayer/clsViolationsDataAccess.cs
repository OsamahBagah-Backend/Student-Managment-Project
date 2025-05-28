using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentsManagementDataAccessLayer
{
    public class clsViolationsDataAccess
    {
        static public DataTable  DataGetAllViolations()
        {
            DataTable Violations = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
          
            string Query = "select Name *from Violations";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Connection.Open();

            try
            {
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Violations.Load(Reader);
                }
            }

            catch(Exception Message)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return Violations;
        }

        static public int FindViolationIDByName(string Name)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ID = -1;
            string Query = "select ID from Violations where Name = @Name";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Name", Name);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int instedID))
                {
                    ID = instedID;
                }
            }

            catch(Exception ex)
            {
                ID = -1;
            }

            finally
            {
                Connection.Close();
            }

            return ID;
        }
    }
}
