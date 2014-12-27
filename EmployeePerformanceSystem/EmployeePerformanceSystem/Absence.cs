using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePerformanceSystem
{
    class Absence
    {
        // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
            private string type;
            private string date;
            private string explained_absence;
            private string unexplained_absence;
            private int attendance; 



       // ACCESSOR METHOD FOR type
            //This method lets me access the data stored in type - this method must be used as the data is private
            public string getType()
            {
                return type;
            }

      // MUTATOR METHOD FOR type
            public void obtainType()
            {
                //the new value must be first obtained from the database and then set to type

                //type = newValue;
            }

      // ACCESSOR METHOD FOR type
            //This method lets me access the data stored in data - this method must be used as the data is private
            public string getDate()
            {
                return date;
            }

      // MUTATOR METHOD FOR type
            public void obtainDate()
            {
                //the new value must be first obtained from the database and then set to date

                //date = newValue;
            }


      // getEmpId() will be called somewhere in this class as it will be needed 
      /*      public void getEmpId()
            {

                // TODO: place method code here 

            }
      */
            
            public void obtainExplainedAbsence()
            {
                //the new value must be first obtained from the database and then set to explained_absence

                //explained_absence = newValue;
            }

            public void obtainUnexplainedAbsence()
            {
                //the new value must be first obtained from the database and then set to unexplained_absence

                //unexplained_absence = newValue;
            }

            public void updateExplainedAbsence()
            {

                //this column in the database will be incremented each time an explained absence occurs

            }

            public void updatedUnexplainedAbsence()
            {

                //this column in the database will be incremented each time an unexplained absence occurs

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

            public string getExplainedAbsense()
            {

                return explained_absence;

            }

            public string getUnexplainedAbsense()
            {

                return unexplained_absence;

            }        

    } // end of Absence class definition

}
