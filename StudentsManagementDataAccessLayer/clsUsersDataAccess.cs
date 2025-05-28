using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace StudentsManagementDataAccessLayer
{
    public class clsUsersDataAccess
    {
        static public int FindByUserNameAndPassWord(string UserName,string PassWord)
        {
            int permission = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select *from Users where UserName = @UserName or password=@PassWord";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@PassWord", PassWord);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    if ((string)Reader["UserName"] != UserName && (string)Reader["password"] == PassWord)
                    {
                        permission = -10;
                    }

                    else if ((string)Reader["UserName"] == UserName && (string)Reader["password"] != PassWord)
                    {
                        permission = -11;
                    }

                    else
                    {
                        permission = (int)Reader["Permission"];
                    }

                    Reader.Close();
                }

                else
                {
                    permission = -12;
                }

            }

            catch(Exception ex)
            {
                //permission = 0;
            }

            finally
            {
                Connection.Close();
            }

            return permission;
        }

        static public DataTable GetAllUsers(string Filter="")
        {
            DataTable AllUsers = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Users";

            Query += Filter;

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    AllUsers.Load(Reader);
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

            return AllUsers;
        }

        static public bool AddNewUser(string UserName,string PassWord,int permission)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "insert into Users values (@Username,@PassWord,@permission)";

            int RowAffected = 0;
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@PassWord", PassWord);
            Command.Parameters.AddWithValue("@permission", permission);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        static public bool DeleteUser(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete from Users where ID=@UserID";
            int RowAffected = 0;

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        static public bool FindUserByID(int ID,ref string UserName,ref string PassWord,ref int permission)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Users where ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    UserName = (string)Reader["UserName"];
                    PassWord = (string)Reader["PassWord"];
                    permission = (int)Reader["Permission"];
                }

                else
                {
                    IsFound = false;
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

        static public bool UpdateUserInfo(int UserID, string UserName, string PassWord,int permission)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int rowAffected = 0;
            string Query = "update Users set UserName=@UserName," +
                                          "PassWord=@PassWord," +
                                          "Permission=@permission where ID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@PassWord", PassWord);
            Command.Parameters.AddWithValue("@Permission",permission );

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
    }
}
