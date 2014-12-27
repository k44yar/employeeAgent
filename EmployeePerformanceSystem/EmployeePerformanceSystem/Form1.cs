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

                private DateTime punctual_time = new DateTime(2009, 8, 1, 0, 0, 0); //make this into a const after you find 
                                                //out the format to set it to 9am everyday.

                private DateTime current_time; //this captures the current time and date

                private bool ontime; //is the user on time? yes/no? (true, false)

                private string DAY;
                private int day;

                private string MONTH;
                private int month;

                public string YEAR;
                public int year;

                private string HOURS;
                private int hours;

                private string MINUTES;
                private int minutes;

                private string SECONDS;
                private int seconds;
                


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
                    time_entered = current_time;
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
                    current_time = DateTime.Now;

                    DAY = current_time.ToString("dd");
                    day = Convert.ToInt32(DAY);

                    MONTH = current_time.ToString("mm");
                    month = Convert.ToInt32(MONTH);

                    YEAR = current_time.ToString("yyyy");
                    year = Convert.ToInt32(YEAR);

                    HOURS = current_time.ToString("HH");
                    hours = Convert.ToInt32(HOURS);

                    /*
                    MINUTES = current_time.ToString("M");
                    minutes = Convert.ToInt32(MINUTES);
                    */

                    minutes = 00;

                    
                    SECONDS = current_time.ToString("ss");
                    seconds = Convert.ToInt32(SECONDS);
                    
                    
                    this.time_label.Text = current_time.ToString("HH:mm:ss");

                    //this.time_label.Text = hours.ToString();

                    

                    
                }

                private void punctal_time_label_Click(object sender, EventArgs e)
                {
                    this.punctal_time_label.Text = punctual_time.ToString();
                }
                
        }
}
