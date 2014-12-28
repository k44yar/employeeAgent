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
            this.punctual_time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
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
            this.time_label.Location = new System.Drawing.Point(217, 20);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(39, 20);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "time";
            // 
            // punctual_time_label
            // 
            this.punctual_time_label.AutoSize = true;
            this.punctual_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.punctual_time_label.Location = new System.Drawing.Point(429, 20);
            this.punctual_time_label.Name = "punctual_time_label";
            this.punctual_time_label.Size = new System.Drawing.Size(183, 20);
            this.punctual_time_label.TabIndex = 2;
            this.punctual_time_label.Text = "Punctual Time:  09:00:00";
            this.punctual_time_label.Click += new System.EventHandler(this.punctal_time_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 504);
            this.Controls.Add(this.punctual_time_label);
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
        private System.Windows.Forms.Label punctual_time_label;
    }
}

