using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public int getLate()
        {
            return late;
        }

    }
}
