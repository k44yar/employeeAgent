using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace EmployeePerformanceSystem
{
    public class Absence
    {
            SqlCeConnection mySqlConnection; //     --- ASK - For sql connection

            // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
            private string type;

            // DATE IS HERE TO FIND OUT ATTENDANCE (CURRENT_DATE - START_DATE)
            private string DATE;
            private DateTime date;

            private string START_DATE;
            private DateTime start_date;

            private int attendance;

            private string EXPLAINED_ABSENCES;
            private int explained_absences;

            private string UNEXPLAINED_ABSENCES;
            private int unexplained_absences;

            private int a = 0;

            private int TESTemp;

            // I HAVE TRIED TO USE THE GET METHOD HERE TO GET THE select_emp_id_number - BUT I GET ERRORS UNDERLINED IN RED
            //Form1 test = new Form1();
            //int a = test.get_select_emp_id_number();         


            private Form1 form1;

            public Absence(Form1 form1)
            {
                this.form1 = form1;
            }

            public void MyFunction()
            {
                 a = form1.get_select_emp_id_number();
                 TESTemp = a + 100;
            }

            public int getTESTemp()
            {
                MyFunction();
                return TESTemp;
            }

            

            public void obtainData()
            {
                //a = 1;


                //the new value must be first obtained from the database and then set to explained_absence

                mySqlConnection = new SqlCeConnection(@"Data Source=C:\Users\Sufian\AppData\Local\EmployeeDatabase.sdf");

                String ABSENCEScmd = "SELECT explained_absences, unexplained_absences, start_date FROM employee WHERE emp_id =" + a;

                SqlCeCommand ABSENCESSqlCommand = new SqlCeCommand(ABSENCEScmd, mySqlConnection);

                try
                {
                    mySqlConnection.Open();

                    SqlCeDataReader ABSENCESSqlDataReader = ABSENCESSqlCommand.ExecuteReader();

                    //lbxEmployees.Items.Clear();

                    while (ABSENCESSqlDataReader.Read())
                    {
                        EXPLAINED_ABSENCES = ABSENCESSqlDataReader["explained_absences"].ToString();
                        explained_absences = int.Parse(EXPLAINED_ABSENCES);

                        UNEXPLAINED_ABSENCES = ABSENCESSqlDataReader["unexplained_absences"].ToString();
                        unexplained_absences = int.Parse(UNEXPLAINED_ABSENCES); 
             
                        START_DATE = ABSENCESSqlDataReader["start_time"].ToString();       
                    }

                    ///////////////////////////////////////////////////////////////////////////////
                    //TESTemp = a + 100;

                }

                catch (SqlCeException ex)
                {
                     //MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        


            public void calculateAttendance()
            {

              /*The absense class will make an instance of each absense. The updateExplainedAbsense() and updateUnexplainedAbsense() 
                will update the database table by incrementing the Explained Absence and Unexplained column in the table by 1 each time
                an instance of Absenses is created to the related EmpID and the Absence type. To calculate attendace, current date will
                be subtracted by start date to find the amount of days worked for. Weekends will need to be subtracted as they are
                not working days. Then a total must be made of both explained and unexplained absenses. The total of absenses will need
                to be divided by the number of days in the company to find the percentage of attendance. (Booked holidays will count as
                attended days, they will not be subtracted as the employee gets paid holidays). The obtain methods are obtaining the
                data from the database and setting them to the private variables.*/

                //attendance = newValue;
                
            }

            public int getAttendance()
            {
                return attendance;
            }

            public int getExplainedAbsense()
            {
                return explained_absences;
            }

            public int getUnexplainedAbsense()
            {
                return unexplained_absences;
            }        

    } // end of Absence class definition

}
