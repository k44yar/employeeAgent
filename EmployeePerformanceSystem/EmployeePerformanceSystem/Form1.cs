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
    //ASK - Everything you write has to be with in "public partial class Form1 : Form {}"
    public partial class Form1 : Form
    {
        SqlCeConnection mySqlConnection; //ASK - For sql connection

        // GLOBAL VARIABLES
        private DateTime time_entered; // the time the employee signed in

        private DateTime punctual_time = new DateTime(0001, 01, 01, 09, 2, 00); // only time needed (punctual time) - first 3 parameters are not important

        private DateTime current_time; //this captures the current time and date

        // for current day
        private string CDAY;
        private int cday;

        private string CMONTH;
        private int cmonth;

        private string CYEAR;
        private int cyear;

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

        // time entered by employee
        private int entered_seconds;
        private int entered_minutes;
        private int entered_hours;

        // employee id being converted to string from a textbox and then an int BUTTON_1
        private string EMP_ID_STRING;
        private int emp_id_number;

        // selected employee id being converted to string from a textbox and then an int SHOW_DATA_BUTTON
        private string SELECT_EMP_ID_STRING;
        private int select_emp_id_number;

        // these variables have been created to send over start_date, explained_absences, unexplained_absences to the Absence class for computation
        // storing from sql statement
        DateTime send_start_date;
        int send_explained_absences;
        int send_unexplained_absences;

        // this variable has been created to send late to the Punctuality class
        // storing from the same sql statement as the variables above
        int send_late;

        // needed to convert auth_id to string from textbox and then make it into a number
        string AUTH_ID;
        int auth_id;


        //ASK - This method is the first method run when the program starts. STARTING POINT

        public Form1()
        {
            InitializeComponent();

            populateListBox();

            timer1.Start(); // Starts the Timer

            this.punctual_time_label.Text = punctual_time.ToString("HH:mm:ss"); // present punctual time (formatted just to show time)

        }
        


        //ASK - IN THIS METHOD ALL THE CURRENT DATE AND TIME DATA IS BEING COLLECTED WHEN TIMER IS RUNNING
        private void timer1_Tick(object sender, EventArgs e)
        {
            // FOR CURRENT TIME
            current_time = DateTime.Now;

            CDAY = current_time.ToString("dd"); // formatted for days
            cday = int.Parse(CDAY);

            CMONTH = current_time.ToString("mm"); // formatted for month
            cmonth = int.Parse(CMONTH);

            CYEAR = current_time.ToString("yyyy"); // formatted for year
            cyear = int.Parse(CYEAR);

            CHOURS = current_time.ToString("HH"); // formatted for hours
            chours = int.Parse(CHOURS);

            CMINUTES = current_time.ToString("mm"); // formatted for minutes
            cminutes = int.Parse(CMINUTES);

            CSECONDS = current_time.ToString("ss"); // formatted for seconds
            cseconds = int.Parse(CSECONDS);


            this.time_label.Text = current_time.ToString("HH:mm:ss"); // present current time on display (formatted to show time only)

        }


        

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void populateListBox()
        {
            try
            {
                // this way of connecting to a database is more professional
                // ConnectionString1 has been predefined as the path to find the employee database

                string ConnString = Properties.Settings.Default.ConnectionString1;
                mySqlConnection = new SqlCeConnection(ConnString);
                mySqlConnection.Open();

                String selcmd = "SELECT * FROM employee WHERE emp_id =" + select_emp_id_number + " ORDER BY emp_id";

                SqlCeCommand mySqlCommand = new SqlCeCommand(selcmd, mySqlConnection);

                SqlCeDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxEmployees.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxEmployees.Items.Add("ID: " + mySqlDataReader["emp_id"] + "   Name: " + mySqlDataReader["name"] + "   Job Role: " + mySqlDataReader["job_role"] + "   Start Date " + mySqlDataReader["start_date"] + "   Late: " + mySqlDataReader["late"] + "   Explained Absences: " + mySqlDataReader["explained_absences"] + "   Unexplained Absences: " + mySqlDataReader["unexplained_absences"]);

                    // THIS IS NEEDED FOR THE ABSENCE CLASS

                    string zzz = mySqlDataReader["start_date"].ToString();
                    send_start_date = DateTime.Parse(zzz);

                    string yyy = mySqlDataReader["explained_absences"].ToString();
                    send_explained_absences = int.Parse(yyy);

                    string xxx = mySqlDataReader["unexplained_absences"].ToString();
                    send_unexplained_absences = int.Parse(xxx);

                    string ooo = mySqlDataReader["late"].ToString();
                    send_late = int.Parse(ooo);

                    mySqlConnection.Close();
                }

            }

            catch (SqlCeException ex)
            {

                MessageBox.Show(" .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //ASK - checking if the input entered is a numeric value

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(search_emp_field.Text))
            {
                MessageBox.Show("Error: Please check your input is a number, or the function has not yet been activated by your superior yet");
                rtnvalue = false;
            }

            return (rtnvalue);
        }


        //ASK - when this button is clicked the following code triggers (EMPLOYEE ENTERED)
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

                try
                {
                    EMP_ID_STRING = emp_id_field.Text;// obtaining the emp_id in the emp field as a string

                    if (System.Text.RegularExpressions.Regex.IsMatch(EMP_ID_STRING, "[^0-9]"))
                    {
                        emp_id_field.Clear();// if the input is not correct the field is cleared
                    }

                    else
                    {
                        emp_id_number = int.Parse(EMP_ID_STRING);// emp_id officially becomes a number here


                        // Displaying the Employee ID on the windows form (assurance reasons)
                        this.ID_Selected_label.Text = EMP_ID_STRING;

                        //ASK - current time is assigned to the entered variables to clock the employee in
                        entered_hours = chours;
                        entered_minutes = cminutes;
                        entered_seconds = cseconds;


                        //ASK - SET PUNCTUAL TIME
                        PHOURS = punctual_time.ToString("HH"); //obtain just hours
                        phours = int.Parse(PHOURS);

                        PMINUTES = punctual_time.ToString("mm"); //obtain just minutes
                        pminutes = int.Parse(PMINUTES);

                        PSECONDS = punctual_time.ToString("ss"); //obtain just seconds
                        pseconds = int.Parse(PSECONDS);

                        // setting time entered on display for assurance reasons
                        this.time_entered_label.Text = current_time.ToString("HH:mm:ss");

                        //ASK - this method is sending the data needed by the Punctuality class to do the computation needed regarding lates
                        int late_percentage;
                        late_percentage = Punctuality.get_late(emp_id_number, send_late, phours, pminutes, pseconds, entered_hours, entered_minutes, entered_seconds);

                        //ASK - after the button has been clicked the report produced is cleared to avoid confusuion
                        lbxEmployees.Items.Clear();
 
                    }
                }

                catch
                {
                    //nothing needs to happen
                }

            }

        }


        //ASK - similar function to the button1 - clicking this button displays the employee data
        private void show_data_button_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                try
                {
                    SELECT_EMP_ID_STRING = search_emp_field.Text;// obtaining the search_emp_id in the search_emp field as a string
                    
                    if (System.Text.RegularExpressions.Regex.IsMatch(SELECT_EMP_ID_STRING, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        
                        search_emp_field.Clear();
                    }

                    else
                    {
                        select_emp_id_number = int.Parse(SELECT_EMP_ID_STRING); //select_emp_id offically becomes a int here

                        populateListBox(); // calls the populateListBox method to display the data
                    }
                }

                catch
                {
                    //nothing needs to happen here
                }
            }

        }

     
       
        // the following code is triggered to calculate the attendance of the employee.
        private void button2_Click(object sender, EventArgs e)
        {
            Absence.checkEmp(select_emp_id_number);
            Absence.checkStartDate(send_start_date);

            // sending the appropraite data to the Absence class
            double attendance;
            attendance = Absence.get_data(select_emp_id_number, send_start_date, current_time , send_explained_absences, send_unexplained_absences);
            textBox6.Text = attendance.ToString();
        }



        // following code is triggered to check authentication id
        private void auth_id_ok_Click(object sender, EventArgs e)
        {
            try
            {
                AUTH_ID = textBox7.Text;
                
                // checking if input is a number
                if (System.Text.RegularExpressions.Regex.IsMatch(AUTH_ID, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    textBox7.Clear();

                }

                else
                {
                    //Auth ID 100 allows user to only clock employees in
                    //Auth ID 101 allows user to only check employees details
                    
                    auth_id = int.Parse(AUTH_ID);


                    ///////////////////////////////////////////////////////////////////////////////////



                    if (auth_id != 101)
                    {
                        show_data_button.Visible = false;
                        label5.Visible = false;
                        search_emp_field.Visible = false;
                        button2.Visible = false;
                        label7.Visible = false;
                        textBox6.Visible = false;
                        lbxEmployees.Visible = false;
                        
                    }




                    if (auth_id == 101)
                    {
                        show_data_button.Visible = true;
                        label5.Visible = true;
                        search_emp_field.Visible = true;
                        button2.Visible = true;
                        label7.Visible = true;
                        textBox6.Visible = true;
                        lbxEmployees.Visible = true;
                        
                    }


                    ///////////////////////////////////////////////////////////////////////////////////

                    
                    if (auth_id != 100)
                    {
                        button1.Visible = false;
                        label2.Visible = false;
                        time_label.Visible = false;
                        label4.Visible = false;
                        emp_id_field.Visible = false;
                        label1.Visible = false;
                        punctual_time_label.Visible = false;
                        label3.Visible = false;
                        time_entered_label.Visible = false;
                        ID_Selected_label.Visible = false;
                    }



                    
                    if (auth_id == 100)
                    {
                        button1.Visible = true;
                        label2.Visible = true;
                        time_label.Visible = true;
                        label4.Visible = true;
                        emp_id_field.Visible = true;
                        label1.Visible = true;
                        punctual_time_label.Visible = true;
                        label3.Visible = true;
                        time_entered_label.Visible = true;
                        ID_Selected_label.Visible = true;
                    }

                    ///////////////////////////////////////////////////////////////////////////////////


                }
            }

            catch
            {
                // nothing needs to happen
            }
        }

    }
}
