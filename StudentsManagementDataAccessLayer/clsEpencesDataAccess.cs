using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentsManagementDataAccessLayer
{
    public class clsEpencesDataAccess
    {
        static public DataTable GetAllBilles(string Filter ="")
        {
            DataTable Bills = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Expenses order by ID" + Filter;

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bills.Load(Reader);
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

            return Bills;
        }

        static public int AddNewBills(string CategoryName,int Quantity,double Price,string BuyingName,
                                      DateTime BuyingDate,double TotalPrice)
        {
            int BillsID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "insert into Expenses values(@CategoryName,@Qauntity,@Price,@BuyingName,@BuyingDate,@TotalPrice); " +
                           "select SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
            Command.Parameters.AddWithValue("@Qauntity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@BuyingName", BuyingName);
            Command.Parameters.AddWithValue("@BuyingDate", BuyingDate);
            Command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(),out int InstedID))
                {
                    BillsID = InstedID;
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

            return BillsID;
        }

        static public bool GetBillByID(int ID,ref string CategoryName,ref int Quantity,ref double Price,
                    ref string BuyerName,ref DateTime BuyingDate,ref double TotalPrice)
        {
            bool IsFound = false;
            DataTable dt = new DataTable();
            decimal price = 0;
            decimal totalPrice = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select *from Expenses where ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    IsFound = true;
                    dt.Load(Reader);

                    foreach(DataRow row in dt.Rows)
                    {
                        if (ID == (int)row["ID"])
                        {
                            CategoryName = (string)row["CategoryName"];
                            Quantity = (int)row["Quantity"];
                            price = (decimal)row["Price"];
                            BuyerName = (string)row["BuyerName"];
                            BuyingDate = (DateTime)row["BuyingDate"];
                            totalPrice = (decimal)row["totalPrice"];

                            Price = (double)price;
                            TotalPrice = (double)totalPrice;

                            break;
                        }
                    }
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

            return IsFound;
        }

        static public bool UpdateBill(int ID,string CategoryName,int Quantity,double Price,
                    string BuyerName, DateTime BuyingDate,double TotalPrice)
        {
            int RowsAffected = 0;
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "update Expenses set CategoryName=@CategoryName, " +
                                               "Quantity = @Quantity, " +
                                               "Price=@Price, " +
                                               "BuyerName=@BuyerName, " +
                                               "BuyingDate=@BuyingDate, " +
                                               "TotalPrice=@TotalPrice where ID=@ID";



            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@BuyerName", BuyerName);
            Command.Parameters.AddWithValue("@BuyingDate", BuyingDate);
            Command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                RowsAffected = 0;
            }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        static public bool DeleteBill(int ID)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete from Expenses where ID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                RowAffected = 0;
            }

            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        static public DataTable GetAllBillesFilter(int Year,int Month)
        {
            DataTable Bills = new DataTable();
            DataTable Bills2 = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select *from Expenses order by ID" ;

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bills.Load(Reader);

                    foreach (DataRow row in Bills.Rows)
                    {
                        DateTime date = (DateTime)row["BuyingDate"];
                        
                        if (Year != 0 && Month != 0)
                        {
                            if ((int)date.Month == Month && (int)date.Year == Year)
                            {
                                Bills2.Rows.Add(row);
                            }
                        }

                        else if (Year != 0)
                        {
                            if ((int)date.Year == Year)
                            {
                                Bills2.Rows.Add(row);
                            }
                        }

                        else if (Month != 0)
                        {
                            if ((int)date.Month == Month)
                            {
                                Bills2.Rows.Add(row);
                            }
                        }
                    }
                }

                Reader.Close();
            }

            catch (Exception ex)
            {
                //
            }

            finally
            {
                Connection.Close();
            }

            return Bills2;
        }
    }
}
