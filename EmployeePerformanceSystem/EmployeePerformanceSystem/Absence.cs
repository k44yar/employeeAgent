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
            // GLOBAL VARIABLES         
                            

            private DateTime start_date;

            private int explained_absences;

            private int unexplained_absences;

            //private DateTime current_date = DateTime.Now;

            
            // GET METHODS TO SEND DATA TO FORM1.CS

            public static double get_data(int id, DateTime start_DATE, DateTime current_time, int explained, int unexplained)
            {

                TimeSpan diff1 = current_time.Subtract(start_DATE);

                string a = diff1.ToString("dd");

                string b = explained.ToString();
                string c = unexplained.ToString();
                
                double TOTAL_DAYS = double.Parse(a);
                double EXPLAINED = double.Parse(b);
                double UNEXPLAINED = double.Parse(c);

                double weekends = TOTAL_DAYS / 7;

                double days_should_work = TOTAL_DAYS - weekends;

                double ALL_ABSENCES = EXPLAINED + UNEXPLAINED;

                double DAYS_WORKED = TOTAL_DAYS - weekends - ALL_ABSENCES;

                double ATTENDANCE = ALL_ABSENCES / days_should_work;

                double ACTUAL_ATTENDANCE = 1 - Math.Round(ATTENDANCE, 2);
  
                return ACTUAL_ATTENDANCE;
                //System.TimeSpan diff1 = current_date.Subtract(START_DATE);

            }
                    
                    // GET METHOD BELOW ARE ALL FOR TESTING PURPOSES - UNCOMMENT THESE AND 
                    // THE LINKED CODE IN FORM1.CS TO POPULATE THE AMSWERS IN THE TEXTBOXES            

                    /*
                    // this sends back the select_emp_id_number back to form1.cs
                    public static int get_select_emp_id_number(int id)
                    {
                        int SendID = id;
                        return SendID; // send to form
                    }



                    // this sends back the start_date back to form1.cs
                    public static DateTime get_start_date(DateTime start_DATE)
                    {
                        DateTime SendLate = start_DATE;
                        return SendLate; // send to form
                    }


                    // this sends back the explained_absences back to form1.cs
                    public static int get_explained_absences(int explained)
                    {
                        int SendExplained = explained;
                        return SendExplained; // send to form
                    }


                    // this sends back the unexplained_absences back to form1.cs
                    public static int get_unexplained_absences(int unexplained)
                    {
                        int SendUnexplained = unexplained;
                        return SendUnexplained; // send to form
                    }*/

            // END OF ALL GET METHODS IN THIS CLASS


            /*
            public void calculateAttendance()
            {

                /*The absense class will make an instance of each absense. The updateExplainedAbsense() and updateUnexplainedAbsense() 
                will update the database table by incrementing the Explained Absence and Unexplained column in the table by 1 each time
                an instance of Absenses is created to the related EmpID and the Absence type. To calculate attendace, current date will
                be subtracted by start date to find the amount of days worked for. Weekends will need to be subtracted as they are
                not working days. Then a total must be made of both explained and unexplained absenses. The total of absenses will need
                to be divided by the number of days in the company to find the percentage of attendance. (Booked holidays will count as
                attended days, they will not be subtracted as the employee gets paid holidays). The obtain methods are obtaining the
                data from the database and setting them to the private variables.

                // use this to find out the attendance - THIS IS AN EXAMPLE

                //System.TimeSpan diff1 = current_date.Subtract(START_DATE);

                //lbxEmployees.Items.Add("Today: " + current_time.ToShortDateString() + "..... " + " Start Date: " + eg_start_date.ToShortDateString() + "..... " + " diiference is " + diff1.Days + " days."); // TESTING


            }
            */



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
