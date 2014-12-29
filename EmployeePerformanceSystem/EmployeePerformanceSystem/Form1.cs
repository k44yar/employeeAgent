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

            //populateListBox();

            timer1.Start(); // starts timer

            this.punctual_time_label.Text = punctual_time.ToString("HH:mm:ss");

        }



        public void populateListBox()
        {
            mySqlConnection =
                    new SqlCeConnection(@"Data Source=C:\Users\Sufian\AppData\Local\EmployeeDatabase.sdf");

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

                    lbxEmployees.Items.Add("ID: " + mySqlDataReader["emp_id"] + "   Name: " + mySqlDataReader["name"] + "   Job Role: " + mySqlDataReader["job_role"] + "   Start Date " + mySqlDataReader["start_date"] + "   Late: " + mySqlDataReader["late"] + "   Explained Absences: " + mySqlDataReader["explained_absences"] + "   Unexplained Absences: " + mySqlDataReader["unexplained_absences"]);

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


        /*public void insertRecord(String ID, String name, String address, String commandString)
        {

            try
            {
                SqlCeCommand cmdInsert = new SqlCeCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@ID", ID);
                cmdInsert.Parameters.AddWithValue("@name", name);
                cmdInsert.Parameters.AddWithValue("@address", address);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/






        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //this.punctual_time_label.Text = current_time.ToString("HH:mm:ss");

            EMP_ID_STRING = emp_id_field.Text;
            emp_id_number = Convert.ToInt32(EMP_ID_STRING);

            this.ID_Selected_label.Text = EMP_ID_STRING;

            //MAKING all the 'pdates' the same as 'cdates'
            PDAY = CDAY;
            pday = cday;

            PMONTH = CMONTH;
            pmonth = cmonth;

            PYEAR = CYEAR;
            pyear = cyear;

            entered_hours = chours;

            entered_minutes = cminutes;

            entered_seconds = cseconds;



            // SET PUNCTUAL TIME
            PHOURS = punctual_time.ToString("HH");
            phours = Convert.ToInt32(PHOURS);

            CMINUTES = punctual_time.ToString("mm");
            cminutes = Convert.ToInt32(CMINUTES);

            PSECONDS = punctual_time.ToString("ss");
            pseconds = Convert.ToInt32(PSECONDS);



            this.time_entered_label.Text = current_time.ToString("HH:mm:ss");
            // this.punctual_time_label.Text = pseconds.ToString(); //TESTING PURPOSE


            //here use DateTime time_entered to find the current time
            if (phours <= entered_hours)
            {
                if (phours <= entered_hours && pminutes <= entered_minutes)
                {

                }


                // this will check if the employee is late, if yes then this method will update the LATE row 
                //in the database EMPLOYEE table

                /* the receptionist can use IT. click the button which takes DateTime as a variable and check if its after
                 9am to check if the employee is late*/

                /*YOU NEED TO FIND A WAY IN WHICH YOU CAN MATCH THE EMPLOYEE TO THE LATES
                  MAYBE BY MAKING A FIELD WHICH TAKES EMP_ID, AND ONCE THIS HAS BEEN ENTERED
                  THEN THIS BUTTON IS VISIBLE TO THE USER
            }
        }*/






        private void button1_Click(object sender, EventArgs e)
        {
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
                    emp_id_number = Convert.ToInt32(EMP_ID_STRING);

                    this.ID_Selected_label.Text = EMP_ID_STRING;
                    //MAKING all the 'pdates' the same as 'cdates'
                    PDAY = CDAY;
                    pday = cday;
                    PMONTH = CMONTH;
                    pmonth = cmonth;
                    PYEAR = CYEAR;
                    pyear = cyear;
                    entered_hours = chours;
                    entered_minutes = cminutes;
                    entered_seconds = cseconds;

                    // SET PUNCTUAL TIME
                    PHOURS = punctual_time.ToString("HH");
                    phours = Convert.ToInt32(PHOURS);

                    CMINUTES = punctual_time.ToString("mm");
                    cminutes = Convert.ToInt32(CMINUTES);

                    PSECONDS = punctual_time.ToString("ss");
                    pseconds = Convert.ToInt32(PSECONDS);
                    this.time_entered_label.Text = current_time.ToString("HH:mm:ss");
                    // this.punctual_time_label.Text = pseconds.ToString(); //TESTING PURPOSE
                    //here use DateTime time_entered to find the current time
                    if (phours <= entered_hours)
                    {
                        if (phours <= entered_hours && pminutes <= entered_minutes)
                        {

                        }
                        // this will check if the employee is late, if yes then this method will update the LATE row 
                        //in the database EMPLOYEE table

                        /* the receptionist can use IT. click the button which takes DateTime as a variable and check if its after
                         9am to check if the employee is late*/

                        /*YOU NEED TO FIND A WAY IN WHICH YOU CAN MATCH THE EMPLOYEE TO THE LATES
                          MAYBE BY MAKING A FIELD WHICH TAKES EMP_ID, AND ONCE THIS HAS BEEN ENTERED
                          THEN THIS BUTTON IS VISIBLE TO THE USER*/
                    }
                }
            }
            catch
            {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nothing yet

            //this.emp_id.Text = "hello"; //TESTING PURPOSE to see what this does
        }

        private void show_data_button_Click(object sender, EventArgs e)
        {
               
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
                        select_emp_id_number = Convert.ToInt32(SELECT_EMP_ID_STRING);

                        //String commandString = "INSERT INTO tblstudent(studentID, studentNAME, studentADDRESS) VALUES (@ID, @name, @address)";

                        //insertRecord(txtId.Text, txtName.Text, txtAddress.Text, commandString);
                        populateListBox();
                        //cleartxtBoxes();
                    }
                }

                catch
                {

                }
            }

        }



    }
}
