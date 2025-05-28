using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementDataAccessLayer;
using System.Data;

namespace StudentsManagementBusinessLayer
{
    public class clsUsersBusiness
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Permission { get; set; }
        public int ID { get; set; }

        private clsUsersBusiness(int ID,string UserName,string PassWord,int Permission)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permission = Permission;
        }

        static public clsUsersBusiness FindUserByID(int ID)
        {
            string UserName = "", PassWord = "";
            int permission = 0;

            if(clsUsersDataAccess.FindUserByID(ID,ref UserName,ref PassWord,ref permission))
            {
                return new clsUsersBusiness(ID,UserName, PassWord, permission);
            }

            else
            {
                return null;
            }
        }

        static public int FindByUserNameAndPassWord(string UserName,string PassWord)
        {
            return clsUsersDataAccess.FindByUserNameAndPassWord(UserName, PassWord);
        }

        static private DataTable _SetThePermissionsValues(DataTable dt)
        {
            DataTable TempDataTable = new DataTable();

            TempDataTable.Columns.Add("ID", typeof(int));
            TempDataTable.Columns.Add("UserName", typeof(string));
            TempDataTable.Columns.Add("PassWord", typeof(string));
            TempDataTable.Columns.Add("StudentMangement", typeof(bool));
            TempDataTable.Columns.Add("ActivitiesMangment", typeof(bool));
            TempDataTable.Columns.Add("ManyMangement", typeof(bool));
            TempDataTable.Columns.Add("pledgsMangment", typeof(bool));
            TempDataTable.Columns.Add("EmployeesMangment", typeof(bool));
            TempDataTable.Columns.Add("UsersMangment", typeof(bool));

            bool StuMang = false, UserMang = false, ManyMang = false, PledManag = false, ActiManag = false, EmpManag = false;

            foreach(DataRow row in dt.Rows)
            {
                if (((int)row["Permission"] & 1 )== 1)
                {
                    StuMang = true;
                }

                if (((int)row["Permission"] & 2) == 2)
                {
                    ActiManag = true;
                }

                if (((int)row["Permission"] & 4) == 4)
                {
                    ManyMang = true;
                }

                if (((int)row["Permission"] & 8) == 8)
                {
                    PledManag = true;
                }

                if (((int)row["Permission"] & 16) == 16)
                {
                    EmpManag = true;
                }

                if (((int)row["Permission"] & 32) == 32)
                {
                    UserMang = true;
                }

                object[] rows = { row["ID"], row["UserName"], row["PassWord"], StuMang, ActiManag, ManyMang, PledManag, EmpManag,UserMang };

                TempDataTable.Rows.Add(rows);

                StuMang = false; UserMang = false; ManyMang = false; PledManag = false; ActiManag = false;EmpManag = false;
            }

            return TempDataTable;
        }
        static public DataTable GetAllUsers(string Filter="")
        {
            DataTable allUsers = new DataTable();
            allUsers = clsUsersDataAccess.GetAllUsers(Filter);
            return  _SetThePermissionsValues(allUsers);
            
        }

        static public bool AddNewUser(string UserName,string PassWord,int permission)
        {
            return clsUsersDataAccess.AddNewUser(UserName, PassWord,permission);
        }

        static public bool DeleteUser(int ID)
        {
            return clsUsersDataAccess.DeleteUser(ID);
        }

        static public bool UpdateUserInfo(int UserID,string UserName,string PassWord,int Permission)
        {
            return clsUsersDataAccess.UpdateUserInfo(UserID, UserName, PassWord,Permission);
        }
    }
}
