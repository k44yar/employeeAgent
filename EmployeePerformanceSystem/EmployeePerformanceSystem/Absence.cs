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
            // GET METHOD TO SEND DATA TO FORM1.CS

            public static double get_data(int id, DateTime start_DATE, DateTime current_time, int explained, int unexplained)
            {

                TimeSpan diff1 = current_time.Subtract(start_DATE); // calculating amount of days from start date til current date

                string a = diff1.ToString("dd"); // only grabbing days nothing else

                string b = explained.ToString(); // have to be converted to strings from an int to convert to double
                string c = unexplained.ToString(); // have to be converted to strings from an int to convert to double
                
                double TOTAL_DAYS = double.Parse(a); // becomes actual int
                double EXPLAINED = double.Parse(b); // becomes actual int
                double UNEXPLAINED = double.Parse(c); // becomes actual int

                double weekends = (TOTAL_DAYS / 7) * 2; // calculating weekends

                double days_should_work = TOTAL_DAYS - weekends; // days the employee should be working excluding the weekends

                double ALL_ABSENCES = EXPLAINED + UNEXPLAINED; // all absences

                double DAYS_WORKED = days_should_work - ALL_ABSENCES; // actual days worked by the employee

                double ATTENDANCE = DAYS_WORKED / days_should_work;

                double ATTENDANCE111 = 1 - ATTENDANCE; // calculating the attendance

                double ACTUAL_ATTENDANCE = 1 - Math.Round(ATTENDANCE111, 2); // rounds the attendance number to 2 decimal places
  
                return ACTUAL_ATTENDANCE; //ASK - this returns the calculated attendance
                

            }


            // ASSURANCE PURPOSES
            // this is logging the start_date and writing the manipulated data to a txt file for debugging purposes
            public static void checkStartDate(DateTime abc)
            {
                DateTime def = abc;

                    // this is setting the start_date to getmsg so the code below can adapt to it
                
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

            
            // ASSURANCE PURPOSES
            // this is logging the emp id and writing the manipulated data to a txt file for debugging purposes
            public static void checkEmp(int abc)
            {
                int def = abc;

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


    } // end of Absence class definition

}
