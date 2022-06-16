using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {
        //private static string cName = "Data Source=DESKTOP-L91OLLD; Initial Catalog=StudentManagement;";
        private static string cName = "Server=DESKTOP-L91OLLD;Database=StudentManagement;Trusted_Connection=True;MultipleActiveResultSets=true";
        public static string CName
        {
            get => cName;
        }
    }
}
