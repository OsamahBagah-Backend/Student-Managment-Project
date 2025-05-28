using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementDataAccessLayer;
using System.Data;

namespace StudentsManagementBusinessLayer
{
    public class ClsViolationsBusiness
    {
        static public DataTable GetAllViolations()
        {
            return clsViolationsDataAccess.DataGetAllViolations();
        }

        static public int GetViolationIDByName(string Name)
        {
            return clsViolationsDataAccess.FindViolationIDByName(Name);
        }
    }
}
