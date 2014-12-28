using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePerformanceSystem
{
        // --- ASK - Everything you write has to be with in "public partial class Form1 : Form {}"
        public partial class Form1 : Form
        {
            // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
                private DateTime time_entered; // the time the employee signed in

                private DateTime punctual_time = new DateTime(0001, 01, 01, 0, 0, 0); //make this into a const after you find 
                                                //out the format to set it to 9am everyday.

                private DateTime current_time; //this captures the current time and date

                private bool ontime; //is the user on time? yes/no? (true, false)

                private string CDAY;
                private int cday;
                private string PDAY;
                private int pday;

                private string CMONTH;
                private int cmonth;
                private string PMONTH;
                private int pmonth;

                private string CYEAR;
                private int cyear;
                private string PYEAR;
                private int pyear;

                private string CHOURS;
                private int chours;
                private string PHOURS;
                private int phours;

                private string CMINUTES;
                private int cminutes;
                private string PMINUTES;
                private int pminutes;

                private string CSECONDS;
                private int cseconds;
                private string PSECONDS;
                private int pseconds;
                


            /*
                int year = moment.Year;
	            int month;
	            int day;
	            int hour;
	            int minute;
                int second;
            */          
            
                 // --- ASK - This method is the first method run when the program starts. STARTING POINT
                public Form1()
                {
                    InitializeComponent();

                    timer1.Start(); // starts timer

                }

                private void button1_Click(object sender, EventArgs e)
                {
                    //MAKING all the 'pdates' the same as 'cdates'
                    PDAY = CDAY;
                    pday = cday;

                    PMONTH = CMONTH;
                    pmonth = cmonth;

                    PYEAR = CYEAR;
                    pyear = cyear;


                    // SET PUNCTUAL TIME
                    PHOURS = current_time.ToString("HH");
                    phours = Convert.ToInt32(PHOURS);

                    CMINUTES = current_time.ToString("mm");
                    cminutes = Convert.ToInt32(CMINUTES);

                    PSECONDS = current_time.ToString("ss");
                    pseconds = Convert.ToInt32(PSECONDS);

                    //this.punctual_time_label.Text = current_time.ToString("HH:mm:ss");


                    this.punctual_time_label.Text = pseconds.ToString(); //TESTING PURPOSE


                    //here use DateTime time_entered to find the current time
                    if(time_entered <= punctual_time)
                    {      
                        // this will check if the employee is late, if yes then this method will update the LATE row 
                        //in the database EMPLOYEE table

                        /* the receptionist can use IT. click the button which takes DateTime as a variable and check if its after
                         9am to check if the employee is late*/

                        /*YOU NEED TO FIND A WAY IN WHICH YOU CAN MATCH THE EMPLOYEE TO THE LATES
                          MAYBE BY MAKING A FIELD WHICH TAKES EMP_ID, AND ONCE THIS HAS BEEN ENTERED
                          THEN THIS BUTTON IS VISIBLE TO THE USER*/
                    }
                }

                private void timer1_Tick(object sender, EventArgs e)
                {
                    // FOR CURRENT TIME
                    current_time = DateTime.Now;

                    CDAY = current_time.ToString("dd");
                    cday = Convert.ToInt32(CDAY);

                    CMONTH = current_time.ToString("mm");
                    cmonth = Convert.ToInt32(CMONTH);

                    CYEAR = current_time.ToString("yyyy");
                    cyear = Convert.ToInt32(CYEAR);

                    CHOURS = current_time.ToString("HH");
                    chours = Convert.ToInt32(CHOURS);
                                
                    CMINUTES = current_time.ToString("mm");
                    cminutes = Convert.ToInt32(CMINUTES);

                    CSECONDS = current_time.ToString("ss");
                    cseconds = Convert.ToInt32(CSECONDS);
                    
                    
                    this.time_label.Text = current_time.ToString("HH:mm:ss");

                    //this.time_label.Text = cminutes.ToString(); //TESTING PURPOSE

                }

                private void punctal_time_label_Click(object sender, EventArgs e)
                {
                    //this.punctual_time_label.Text = punctual_time.ToString();
                }
                
        }
}
