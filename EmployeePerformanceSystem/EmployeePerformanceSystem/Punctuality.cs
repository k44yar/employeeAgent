using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;

namespace EmployeePerformanceSystem
{
    class Punctuality
    {     

        public static int get_late(int empl_id, int late, int phours, int pminutes, int pseconds, int entered_hours, int entered_minutes, int entered_seconds)
        {
            
            int yourlate = late + 1;
            SqlCeConnection mySqlConnection;

            // this way of connecting to a database is more professional
            // ConnectionString1 has been predefined as the path to find the employee database

            string ConnString = Properties.Settings.Default.ConnectionString1;
            mySqlConnection = new SqlCeConnection(ConnString);
            mySqlConnection.Open();


            if (phours < entered_hours || (phours == entered_hours && pminutes <= entered_minutes))
            {

                String updatecmd = "UPDATE employee SET late =" + yourlate + " WHERE emp_id = " + empl_id;

                SqlCeCommand mySqlCommand = new SqlCeCommand(updatecmd, mySqlConnection);

                try
                {

                    SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                }

                catch (SqlCeException ex)
                {
                   // nothing needed here
                }
            }


            mySqlConnection.Close();
            return yourlate;
        }


    }
}
