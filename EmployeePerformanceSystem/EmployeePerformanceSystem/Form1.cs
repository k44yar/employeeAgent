using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace EmployeePerformanceSystem
{
        // --- ASK - Everything you write has to be with in "public partial class Form1 : Form {}"
    public partial class Form1 : Form
    {
        SqlCeConnection mySqlConnection; //     --- ASK - For sql connection

        // GLOBAL VARIABLES                                       --- ASK - Global Varaibales being assigned
        private DateTime time_entered; // the time the employee signed in

        private DateTime punctual_time = new DateTime(0001, 01, 01, 09, 2, 00); //make this into a const after you find 
        //out the format to set it to 9am everyday.

        private DateTime current_time; //this captures the current time and date

        //private DateTime current_date = DateTime.Now; TESTING PURPOSES


        private bool ontime; //is the user on time? yes/no? (true, false)

        // for days
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


        // for time
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

        private string ENTERED_SECONDS;
        private int entered_seconds;

        private string ENTERED_MINUTES;
        private int entered_minutes;

        private string ENTERED_HOURS;
        private int entered_hours;

        private string EMP_ID_STRING;
        private int emp_id_number;

        private string SELECT_EMP_ID_STRING;
        private int select_emp_id_number;

        private string LATE;
        private int late;
        private int yourlate;

        DateTime eg_start_date;


        // --- ASK - This method is the first method run when the program starts. STARTING POINT
        
        public Form1()
        {
            InitializeComponent();

            populateListBox();

            timer1.Start(); // starts timer

            this.punctual_time_label.Text = punctual_time.ToString("HH:mm:ss");

            //this.label6.Text = current_date.ToString("dd/MM/yyyy"); TESTING PURPOSE
        }
        


        // THE TIMER HERE IS PICKING UP THE CURRENT TIME
        private void timer1_Tick(object sender, EventArgs e)
        {
            // FOR CURRENT TIME
            current_time = DateTime.Now;

            CDAY = current_time.ToString("dd");
            cday = int.Parse(CDAY);

            CMONTH = current_time.ToString("mm");
            cmonth = int.Parse(CMONTH);

            CYEAR = current_time.ToString("yyyy");
            cyear = int.Parse(CYEAR);

            CHOURS = current_time.ToString("HH");
            chours = int.Parse(CHOURS);

            CMINUTES = current_time.ToString("mm");
            cminutes = int.Parse(CMINUTES);

            CSECONDS = current_time.ToString("ss");
            cseconds = int.Parse(CSECONDS);


            this.time_label.Text = current_time.ToString("HH:mm:ss");

            //this.time_label.Text = cminutes.ToString(); //TESTING PURPOSE

        }



        public void populateListBox()
        {
            mySqlConnection = new SqlCeConnection(@"Data Source=C:\Users\Sufian\AppData\Local\EmployeeDatabase.sdf");

            //String selcmd = "SELECT * FROM employee ORDER BY emp_id";

            String selcmd = "SELECT * FROM employee WHERE emp_id =" + select_emp_id_number + " ORDER BY emp_id";

            SqlCeCommand mySqlCommand = new SqlCeCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxEmployees.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    // THIS IS FOR TESTING - example of using the datetime to subtract
                    string zzz = mySqlDataReader["start_date"].ToString();
                    eg_start_date = DateTime.Parse(zzz);

                    lbxEmployees.Items.Add("ID: " + mySqlDataReader["emp_id"] + "   Name: " + mySqlDataReader["name"] + "   Job Role: " + mySqlDataReader["job_role"] + "   Start Date " + mySqlDataReader["start_date"] + "   Late: " + mySqlDataReader["late"] + "   Explained Absences: " + mySqlDataReader["explained_absences"] + "   Unexplained Absences: " + mySqlDataReader["unexplained_absences"]);
                }

            }

            catch (SqlCeException ex)
            {

                MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        /* UNDERNEATH YOU HAVE MANAGED TO UPDATE THE EMPLOYEE TABLE - HOWEVER ITS HARDCODED IT SETS LATE
           TO 10, YOU NEED TO MAKE ANOTHER METHOD WHICH OBTAINS THE VALUE OF THE EMPLOYEE WHICH CAME IN LATE */

        public void updateLates()
        {
            mySqlConnection = new SqlCeConnection(@"Data Source=C:\Users\Sufian\AppData\Local\EmployeeDatabase.sdf");

            //String LATEcmd = "SELECT late FROM employee WHERE emp_id =" + emp_id_number;
            String updatecmd = "UPDATE employee SET late =" + yourlate + "WHERE emp_id =" + emp_id_number;

            SqlCeCommand mySqlCommand = new SqlCeCommand(updatecmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxEmployees.Items.Clear();
            }

            catch (SqlCeException ex)
            {
                MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void selectLates()
        {
            mySqlConnection = new SqlCeConnection(@"Data Source=C:\Users\Sufian\AppData\Local\EmployeeDatabase.sdf");

            String LATEcmd = "SELECT late FROM employee WHERE emp_id =" + select_emp_id_number;

            SqlCeCommand LATESqlCommand = new SqlCeCommand(LATEcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlCeDataReader LATESqlDataReader = LATESqlCommand.ExecuteReader();

                lbxEmployees.Items.Clear();

                while (LATESqlDataReader.Read())
                {

                    //lbxEmployees.Items.Add("Late: " + LATESqlDataReader["late"]); // TESTING
                    LATE = LATESqlDataReader["late"].ToString();
                    late = int.Parse(LATE);
                    yourlate = late + 1;

                }

            }

            catch (SqlCeException ex)
            {
                MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(search_emp_field.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            selectLates();
            
            try
            {
                //this.punctual_time_label.Text = current_time.ToString("HH:mm:ss");
                EMP_ID_STRING = emp_id_field.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(EMP_ID_STRING, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    emp_id_field.Clear();

                }

                else
                {
                    emp_id_number = int.Parse(EMP_ID_STRING);
                    ///////////////////////////////////////////////////////////////////////////////////////////////
                    //selectLates();

                    // PRINTING THE EMP_ID_STRING TO THE LABEL ON THE INTERFACE
                    this.ID_Selected_label.Text = EMP_ID_STRING;
                    
                    // NOT NEEDED HERE - THIS WOULD BE NEEDED FOR ATTENDANCE
                    // MAKING all the 'pdates' the same as 'cdates'
                    /*
                    PDAY = CDAY;
                    pday = cday;
                    PMONTH = CMONTH;
                    pmonth = cmonth;
                    PYEAR = CYEAR;
                    pyear = cyear;
                    */

                    entered_hours = chours;
                    entered_minutes = cminutes;
                    entered_seconds = cseconds;
                    

                    // SET PUNCTUAL TIME
                    PHOURS = punctual_time.ToString("HH");
                    phours = int.Parse(PHOURS);

                    CMINUTES = punctual_time.ToString("mm");
                    cminutes = int.Parse(CMINUTES);

                    PSECONDS = punctual_time.ToString("ss");
                    pseconds = int.Parse(PSECONDS);

                    // SETTING TIME ENTERED ON INTERFACE "..."
                    this.time_entered_label.Text = current_time.ToString("HH:mm:ss");


                    // CHECKING IF THE EMPLOYEE HAS ENTERED THE BUILDING LATE
                   
                    // THIS WILL CHECK IF THE EMPLOYEE IS LATE, HOWEVER IT IS WITHIN 10AM
                    if (phours == entered_hours && pminutes <= entered_minutes)
                    {
                        updateLates();
                    }

                    // THIS WILL HAPPEN IF THE EMPLOYEE HAS ENTERED AT 10AM OR LATER (THIS IS JUST FOR HOURS)
                    else if (phours < entered_hours)
                    {
                        updateLates();
                    }

                }
            }
            catch
            {

            }

        }



        private void show_data_button_Click(object sender, EventArgs e)
        {
            
            //Absence.AbsenceWriteToLogFile("Absence "); 

            if (checkInputs())
            {
                try
                {
                    SELECT_EMP_ID_STRING = search_emp_field.Text;
                    
                    if (System.Text.RegularExpressions.Regex.IsMatch(SELECT_EMP_ID_STRING, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        
                        search_emp_field.Clear();
                    }

                    else
                    {
                        select_emp_id_number = int.Parse(SELECT_EMP_ID_STRING);

                        Absence.checkEmp(select_emp_id_number);
                        
                        //
                        int ReceiveFormAbsence = 0;
                        ReceiveFormAbsence = Absence.get_select_emp_id_number(select_emp_id_number);
                        textBox2.Text = ReceiveFormAbsence.ToString();
                        //

                        populateListBox();
                    }
                }

                catch
                {

                }
            }

        }

     
        /* KEEP THIS JUST INCASE
        // use this to find out the attendance - THIS IS AN EXAMPLE
        private void dateFunction(DateTime current_time, DateTime eg_start_date)
        {
            System.TimeSpan diff1 = current_time.Subtract(eg_start_date);
            
            lbxEmployees.Items.Add("Today: " + current_time.ToShortDateString() + "..... " + " Start Date: " + eg_start_date.ToShortDateString() + "..... " + " diiference is " + diff1.Days + " days."); // TESTING
        } 
        */





        // I AM TRYING TO USE THIS GET METHOD IN THE 'Absences.cs' CLASS
        public int get_select_emp_id_number()
        {
            return select_emp_id_number;
        }


        private void punctal_time_label_Click(object sender, EventArgs e)
        {
            //NOT NEEDED BUT HAS TO STAY OR APPLICATION CRASHES
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //NOT NEEDED BUT HAS TO STAY OR APPLICATION CRASHES
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //dateFunction(current_time, eg_start_date);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

    }
}
