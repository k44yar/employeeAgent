using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePerformanceSystem
{
    class Project
    {
        // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
            private string proj_name;
            private int foreign_emp_id;
            //private int row_id; 
        
        
        // THE TWO METHODS BELOW ARE NOT NEEDED, HOWEVER KEEP THEM JUST INCASE row_id IS NEEDED IN THE FUTURE
        /*
        // ACCESSOR METHOD FOR type
          public int getRowId()   {
              return row_id;
          }

       // MUTATOR METHOD FOR type
          public void setRowId()   {
              row_id = newValue;
          }
        */

       // ACCESSOR METHOD FOR type
          public string getProjName()
          {
              return proj_name;
          }

       // MUTATOR METHOD FOR type
          public void obtainProjName()
          {
              //the new value must be first obtained from the database and then set to proj_name             
              
              //proj_name = newValue;
          }

       // ACCESSOR METHOD FOR type
          public int getForeignEmpId()
          {
              return foreign_emp_id;
          }

      // MUTATOR METHOD FOR type
          public void obtainForeignEmpId ()
          {
              //the new value must be first obtained from the database and then set to foreign_emp_id

              //the whole purpose of this foreign_emp_id being used is because project will be in its own table
              //in a SQL query... a where clause will be used to identify the employee and the related project
              //WHERE employee.emp_id = project.foreign_emp_id
              
              //foreign_emp_id = newValue;
          }

    }
}
