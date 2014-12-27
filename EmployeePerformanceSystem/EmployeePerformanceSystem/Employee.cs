using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.IO;

namespace EmployeePerformanceSystem
{
    class Employee
    {
        // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
            private int emp_id;
            private string name;
            private string job_role;
            private string txt_start_date;
            private DateTime start_date;
                 
        
       

        // ACCESSOR METHOD FOR emp_id
            //This method lets me access the data stored in emp_id - this method must be used as the data is private
            public float getEmpId()
            {
                return emp_id;
            }

        //MUTATOR METHOD FOR emp_id
            public void obtainEmpId()    
            {
                //the new value must be first obtained from the database and then set to emp_id
              
                //emp_id = newValue;
            }

        //ACCESSOR METHOD FOR name
            public string getName()   
            {
                return name;
            }

        //MUTATOR METHOD FOR name
            public void obtainName ()    
            {
                //the new value must be first obtained from the database and then set to name
              
                //name = newValue;
            }

        //ACCESSOR METHOD FOR job_role
            public string getJobRole()   
            {
                return job_role;
            }

        //MUTATOR METHOD FOR job_role
            public void obtainJobRole()
            {
                //the new value must be first obtained from the database and then set to job_role
              
                //job_role = newValue;
            }

        //ACCESSOR METHOD FOR start_date
            public DateTime getStartDate()
            {
                return start_date;
            }

        //MUTATOR METHOD FOR start_date
            public void obtainStartDate()
            {
                  //the new value must be first obtained from the database and then set to txt_start_date          
       
                  //txt_start_date = newValue;
                
                  //cast txt_start_date from a string to DateTime format and store it in start_date

                  //example of using DateTime //DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
              }


        // THE FOLLOWING METHODS HAVE ALREADY BEEN CREATED IN THE OTHER CLASSES
        //I ADDED THEM TO QSEE DIAGRAM JUST TO SHOW THESE METHODS WILL BE CALLED UPON BY THE MAIN PAGE (most likely form1.cs).
                            /*

                              //ACCESSOR METHOD - gaining access from the Absence class
                                  public void getAttendance()
                                  {

                                      // TODO: place method code here

                                  }

                             //ACCESSOR METHOD - gaining access from the Absence class
                                  public void getExplainedAbsense()
                                  {

                                      // TODO: place method code here

                                  }

                             //ACCESSOR METHOD - gaining access from the Absence class
                                  public void getUnexplainedAbsense()
                                  {

                                      // TODO: place method code here

                                  }

                            //ACCESSOR METHOD - gaining access from the Project class
                                  public void getProjName()
                                  {

                                      // TODO: place method code here

                                  }
       
                           */ 

    } // end of Absence class definition

}
