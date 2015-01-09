namespace EmployeePerformanceSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.time_entered_label = new System.Windows.Forms.Label();
            this.punctual_time_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_id_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_Selected_label = new System.Windows.Forms.Label();
            this.show_data_button = new System.Windows.Forms.Button();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_emp_field = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.auth_id_ok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Employee Entered";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.time_label.Location = new System.Drawing.Point(350, 151);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(21, 20);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "...";
            this.time_label.Visible = false;
            // 
            // time_entered_label
            // 
            this.time_entered_label.AutoSize = true;
            this.time_entered_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.time_entered_label.Location = new System.Drawing.Point(642, 191);
            this.time_entered_label.Name = "time_entered_label";
            this.time_entered_label.Size = new System.Drawing.Size(21, 20);
            this.time_entered_label.TabIndex = 2;
            this.time_entered_label.Text = "...";
            this.time_entered_label.Visible = false;
            // 
            // punctual_time_label
            // 
            this.punctual_time_label.AutoSize = true;
            this.punctual_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.punctual_time_label.Location = new System.Drawing.Point(642, 150);
            this.punctual_time_label.Name = "punctual_time_label";
            this.punctual_time_label.Size = new System.Drawing.Size(21, 20);
            this.punctual_time_label.TabIndex = 3;
            this.punctual_time_label.Text = "...";
            this.punctual_time_label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(529, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punctual Time: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(245, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Time: ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(528, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Entered: ";
            this.label3.Visible = false;
            // 
            // emp_id_field
            // 
            this.emp_id_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emp_id_field.Location = new System.Drawing.Point(353, 189);
            this.emp_id_field.Name = "emp_id_field";
            this.emp_id_field.Size = new System.Drawing.Size(62, 26);
            this.emp_id_field.TabIndex = 7;
            this.emp_id_field.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(245, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee ID: ";
            this.label4.Visible = false;
            // 
            // ID_Selected_label
            // 
            this.ID_Selected_label.AutoSize = true;
            this.ID_Selected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID_Selected_label.Location = new System.Drawing.Point(529, 233);
            this.ID_Selected_label.Name = "ID_Selected_label";
            this.ID_Selected_label.Size = new System.Drawing.Size(93, 20);
            this.ID_Selected_label.TabIndex = 9;
            this.ID_Selected_label.Text = "ID Selected";
            this.ID_Selected_label.Visible = false;
            // 
            // show_data_button
            // 
            this.show_data_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_data_button.Location = new System.Drawing.Point(23, 291);
            this.show_data_button.Name = "show_data_button";
            this.show_data_button.Size = new System.Drawing.Size(140, 38);
            this.show_data_button.TabIndex = 12;
            this.show_data_button.Text = "Show Employee Data";
            this.show_data_button.UseVisualStyleBackColor = true;
            this.show_data_button.Visible = false;
            this.show_data_button.Click += new System.EventHandler(this.show_data_button_Click);
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 16;
            this.lbxEmployees.Location = new System.Drawing.Point(24, 355);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(938, 36);
            this.lbxEmployees.TabIndex = 13;
            this.lbxEmployees.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(194, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Employee ID: ";
            this.label5.Visible = false;
            // 
            // search_emp_field
            // 
            this.search_emp_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_emp_field.Location = new System.Drawing.Point(352, 297);
            this.search_emp_field.Name = "search_emp_field";
            this.search_emp_field.Size = new System.Drawing.Size(62, 26);
            this.search_emp_field.TabIndex = 15;
            this.search_emp_field.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(531, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Show Attendance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(899, 300);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(63, 26);
            this.textBox6.TabIndex = 24;
            this.textBox6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(768, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Attendance: ";
            this.label7.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(114, 80);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 27);
            this.textBox7.TabIndex = 27;
            // 
            // auth_id_ok
            // 
            this.auth_id_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth_id_ok.Location = new System.Drawing.Point(23, 79);
            this.auth_id_ok.Name = "auth_id_ok";
            this.auth_id_ok.Size = new System.Drawing.Size(75, 28);
            this.auth_id_ok.TabIndex = 28;
            this.auth_id_ok.Text = "Auth ID OK";
            this.auth_id_ok.UseVisualStyleBackColor = true;
            this.auth_id_ok.Click += new System.EventHandler(this.auth_id_ok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Employee Performance System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Developed by: Abu Sufian Kayar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.auth_id_ok);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.search_emp_field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxEmployees);
            this.Controls.Add(this.show_data_button);
            this.Controls.Add(this.ID_Selected_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emp_id_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punctual_time_label);
            this.Controls.Add(this.time_entered_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label time_entered_label;
        private System.Windows.Forms.Label punctual_time_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_id_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ID_Selected_label;
        private System.Windows.Forms.Button show_data_button;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_emp_field;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button auth_id_ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

