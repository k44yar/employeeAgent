using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;

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

            private DateTime current_date = DateTime.Now;

            


            // this sends back the select_emp_id_number back to form1.cs
            public static int get_select_emp_id_number(int ReceiveFormForm1)
            {
                int SendToForm1 = ReceiveFormForm1 + 100;
                return SendToForm1;
            }



            // this sends back the select_emp_id_number back to form1.cs
            public static DateTime get_start_date(DateTime start_date_)
            {
                DateTime SendToForm2 = start_date_.AddDays(10);
                return SendToForm2;
            }


            // this sends back the select_emp_id_number back to form1.cs
            public static int get_explained_absences(int explained)
            {
                int SendToForm3 = explained + 50;
                return SendToForm3;
            }


            // this sends back the select_emp_id_number back to form1.cs
            public static int get_unexplained_absences(int unexplained)
            {
                int SendToForm4 = unexplained + 150;
                return SendToForm4;
            }


            public static void checkStartDate(DateTime abc)
            {
                DateTime def = abc.AddDays(10);

                //Punctuality.WriteToLogFile(def.ToString());

                // this is setting the select_emp_id_number to getmsg so the below code can adapt to it
                string getmsg = def.ToString();

                DateTime theDate;
                theDate = DateTime.Now;
                string tmp = theDate.Day.ToString().PadLeft(2, '0');
                tmp = tmp + theDate.Month.ToString().PadLeft(2, '0');
                tmp = tmp + theDate.Year.ToString().PadLeft(4, '0');
                StreamWriter SW;
                String LogFile;
                LogFile = "C:\\Test\\" + tmp + ".log";
                if (File.Exists(LogFile))
                {
                    SW = File.AppendText(LogFile);
                    if (getmsg == "" || getmsg == "SEND" || getmsg == "RECEIVE" || getmsg == "RECEIVE COMPLETE" || getmsg == "START: SEND-RECEIVE" || getmsg == "SEND COMPLETE")
                    {
                        SW.WriteLine(getmsg);
                    }
                    else
                    {
                        SW.WriteLine("  TIME : " + DateTime.Now + " | " + getmsg);
                    }
                    //SW.Close();            
                }
                else
                {
                    SW = File.CreateText("C:\\Test\\" + tmp + ".log");
                    if (getmsg == "" || getmsg == "SEND" || getmsg == "RECEIVE" || getmsg == "RECEIVE COMPLETE" || getmsg == "START: SEND-RECEIVE" || getmsg == "SEND COMPLETE")
                    {
                        SW.WriteLine(getmsg);
                    }
                    else
                    {
                        SW.WriteLine("  TIME : " + DateTime.Now + " | " + getmsg);
                    }
                }
                SW.Close();

            }

            



            // this is logging the emp id and writing the manipulated data to a txt file for debugging purposes
            public static void checkEmp(int abc)
            {
                int def = abc + 100;

                //Punctuality.WriteToLogFile(def.ToString());
                    
                    // this is setting the select_emp_id_number to getmsg so the below code can adapt to it
                    string getmsg = def.ToString();

                    DateTime theDate;
                    theDate = DateTime.Now;
                    string tmp = theDate.Day.ToString().PadLeft(2, '0');
                    tmp = tmp + theDate.Month.ToString().PadLeft(2, '0');
                    tmp = tmp + theDate.Year.ToString().PadLeft(4, '0');
                    StreamWriter SW;
                    String LogFile;
                    LogFile = "C:\\Test\\" + tmp + ".log";
                    if (File.Exists(LogFile))
                    {
                        SW = File.AppendText(LogFile);
                        if (getmsg == "" || getmsg == "SEND" || getmsg == "RECEIVE" || getmsg == "RECEIVE COMPLETE" || getmsg == "START: SEND-RECEIVE" || getmsg == "SEND COMPLETE")
                        {
                            SW.WriteLine(getmsg);
                        }
                        else
                        {
                            SW.WriteLine("  TIME : " + DateTime.Now + " | " + getmsg);
                        }
                        //SW.Close();            
                    }
                    else
                    {
                        SW = File.CreateText("C:\\Test\\" + tmp + ".log");
                        if (getmsg == "" || getmsg == "SEND" || getmsg == "RECEIVE" || getmsg == "RECEIVE COMPLETE" || getmsg == "START: SEND-RECEIVE" || getmsg == "SEND COMPLETE")
                        {
                            SW.WriteLine(getmsg);
                        }
                        else
                        {
                            SW.WriteLine("  TIME : " + DateTime.Now + " | " + getmsg);
                        }
                    }
                    SW.Close();

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

                // use this to find out the attendance - THIS IS AN EXAMPLE
                
                    //System.TimeSpan diff1 = current_time.Subtract(START_DATE);
            
                    //lbxEmployees.Items.Add("Today: " + current_time.ToShortDateString() + "..... " + " Start Date: " + eg_start_date.ToShortDateString() + "..... " + " diiference is " + diff1.Days + " days."); // TESTING
                
                
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
