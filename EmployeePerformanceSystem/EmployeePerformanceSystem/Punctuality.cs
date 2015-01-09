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
        // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
            private int late;

        // this method has moved to the Form1.cs as a button method - KEEP THIS FOR REFERENCE
        /*
        public void checkLate()
        {

            // this will check if the employee is late, if yes then this method will update the LATE row 
            //in the database EMPLOYEE table

            // lates regarding the employee are expected to be already inserted into the database via the receptionist
            // this method will only increment the LATE field

            // the receptionist can use it somehow to click a button which takes DateTime as a variable and check if its after
            // 9am to check if the employee is late

        }
        */

        public void obtainLate()
        {

            //the new value must be first obtained from the database and then set to late

            //late = newValue;

        }

        /*
        public int getLate()
        {
            return late;
        }
        */

        public static int get_late(int empl_id, int late, int phours, int pminutes, int pseconds, int entered_hours, int entered_minutes, int entered_seconds)
        {
            
            int yourlate = late + 1;

            SqlCeConnection mySqlConnection = new SqlCeConnection(@"Data Source=C:\Users\Sufian\AppData\Local\EmployeeDatabase.sdf");


            if (phours == entered_hours && pminutes <= entered_minutes)
            {
                //updateLates();  //IMPORTANT TO UPDATE 

                String updatecmd = "UPDATE employee SET late =" + yourlate + " WHERE emp_id = " + empl_id;

                SqlCeCommand mySqlCommand = new SqlCeCommand(updatecmd, mySqlConnection);

                try
                {
                    mySqlConnection.Open();

                    SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    //lbxEmployees.Items.Clear();
                }

                catch (SqlCeException ex)
                {
                   // MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // THIS WILL HAPPEN IF THE EMPLOYEE HAS ENTERED AT 10AM OR LATER (THIS IS JUST FOR HOURS)
            else if (phours < entered_hours)
            {
                //updateLates();  //IMPORTANT TO UPDATE LATES

                String updatecmd = "UPDATE employee SET late =" + yourlate + " WHERE emp_id = " + empl_id;

                SqlCeCommand mySqlCommand = new SqlCeCommand(updatecmd, mySqlConnection);

                try
                {
                    mySqlConnection.Open();

                    SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    //lbxEmployees.Items.Clear();
                }

                catch (SqlCeException ex)
                {
                    // MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            return yourlate;
        }



 

        

        


        

    }
}
