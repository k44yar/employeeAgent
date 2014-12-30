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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Employee Entered";
            this.button1.UseVisualStyleBackColor = true;
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
            this.time_label.Location = new System.Drawing.Point(352, 21);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(21, 20);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "...";
            // 
            // time_entered_label
            // 
            this.time_entered_label.AutoSize = true;
            this.time_entered_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.time_entered_label.Location = new System.Drawing.Point(644, 61);
            this.time_entered_label.Name = "time_entered_label";
            this.time_entered_label.Size = new System.Drawing.Size(21, 20);
            this.time_entered_label.TabIndex = 2;
            this.time_entered_label.Text = "...";
            this.time_entered_label.Click += new System.EventHandler(this.punctal_time_label_Click);
            // 
            // punctual_time_label
            // 
            this.punctual_time_label.AutoSize = true;
            this.punctual_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.punctual_time_label.Location = new System.Drawing.Point(643, 20);
            this.punctual_time_label.Name = "punctual_time_label";
            this.punctual_time_label.Size = new System.Drawing.Size(0, 20);
            this.punctual_time_label.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(530, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punctual Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Time: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(530, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Entered: ";
            // 
            // emp_id_field
            // 
            this.emp_id_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emp_id_field.Location = new System.Drawing.Point(355, 59);
            this.emp_id_field.Name = "emp_id_field";
            this.emp_id_field.Size = new System.Drawing.Size(62, 26);
            this.emp_id_field.TabIndex = 7;
            this.emp_id_field.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(247, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee ID: ";
            // 
            // ID_Selected_label
            // 
            this.ID_Selected_label.AutoSize = true;
            this.ID_Selected_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID_Selected_label.Location = new System.Drawing.Point(531, 103);
            this.ID_Selected_label.Name = "ID_Selected_label";
            this.ID_Selected_label.Size = new System.Drawing.Size(93, 20);
            this.ID_Selected_label.TabIndex = 9;
            this.ID_Selected_label.Text = "ID Selected";
            // 
            // show_data_button
            // 
            this.show_data_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_data_button.Location = new System.Drawing.Point(25, 136);
            this.show_data_button.Name = "show_data_button";
            this.show_data_button.Size = new System.Drawing.Size(140, 38);
            this.show_data_button.TabIndex = 12;
            this.show_data_button.Text = "Show Employee Data";
            this.show_data_button.UseVisualStyleBackColor = true;
            this.show_data_button.Click += new System.EventHandler(this.show_data_button_Click);
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 16;
            this.lbxEmployees.Location = new System.Drawing.Point(26, 193);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(938, 36);
            this.lbxEmployees.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(196, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Employee ID: ";
            // 
            // search_emp_field
            // 
            this.search_emp_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search_emp_field.Location = new System.Drawing.Point(354, 142);
            this.search_emp_field.Name = "search_emp_field";
            this.search_emp_field.Size = new System.Drawing.Size(62, 26);
            this.search_emp_field.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 639);
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
    }
}

