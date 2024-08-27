namespace HospitalManagementSystems
{
    partial class AppointmentScheduleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendarScheduleAppointment = new System.Windows.Forms.MonthCalendar();
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSearchDoctor = new System.Windows.Forms.ComboBox();
            this.buttonSearchPatients = new System.Windows.Forms.Button();
            this.textBoxSearchCriteria = new System.Windows.Forms.TextBox();
            this.labelCriteria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Appointment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // monthCalendarScheduleAppointment
            // 
            this.monthCalendarScheduleAppointment.Location = new System.Drawing.Point(728, 374);
            this.monthCalendarScheduleAppointment.Name = "monthCalendarScheduleAppointment";
            this.monthCalendarScheduleAppointment.TabIndex = 2;
            // 
            // buttonScheduleAppointment
            // 
            this.buttonScheduleAppointment.BackColor = System.Drawing.Color.LightGreen;
            this.buttonScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleAppointment.Location = new System.Drawing.Point(150, 535);
            this.buttonScheduleAppointment.Name = "buttonScheduleAppointment";
            this.buttonScheduleAppointment.Size = new System.Drawing.Size(156, 49);
            this.buttonScheduleAppointment.TabIndex = 18;
            this.buttonScheduleAppointment.Text = "Schedule Appointment";
            this.buttonScheduleAppointment.UseVisualStyleBackColor = false;
            this.buttonScheduleAppointment.Click += new System.EventHandler(this.buttonScheduleAppointment_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(349, 535);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(156, 49);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(379, 374);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(270, 26);
            this.dateTimePickerDOB.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date Of Birth";
            // 
            // comboBoxSearchCriteria
            // 
            this.comboBoxSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchCriteria.FormattingEnabled = true;
            this.comboBoxSearchCriteria.Location = new System.Drawing.Point(129, 374);
            this.comboBoxSearchCriteria.Name = "comboBoxSearchCriteria";
            this.comboBoxSearchCriteria.Size = new System.Drawing.Size(162, 28);
            this.comboBoxSearchCriteria.TabIndex = 22;
            this.comboBoxSearchCriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchCriteria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search Criteria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Search Doctor";
            // 
            // comboBoxSearchDoctor
            // 
            this.comboBoxSearchDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchDoctor.FormattingEnabled = true;
            this.comboBoxSearchDoctor.Location = new System.Drawing.Point(129, 450);
            this.comboBoxSearchDoctor.Name = "comboBoxSearchDoctor";
            this.comboBoxSearchDoctor.Size = new System.Drawing.Size(162, 28);
            this.comboBoxSearchDoctor.TabIndex = 24;
            // 
            // buttonSearchPatients
            // 
            this.buttonSearchPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearchPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPatients.Location = new System.Drawing.Point(545, 427);
            this.buttonSearchPatients.Name = "buttonSearchPatients";
            this.buttonSearchPatients.Size = new System.Drawing.Size(156, 49);
            this.buttonSearchPatients.TabIndex = 26;
            this.buttonSearchPatients.Text = "Search Patients";
            this.buttonSearchPatients.UseVisualStyleBackColor = false;
            this.buttonSearchPatients.Click += new System.EventHandler(this.buttonSearchPatients_Click);
            // 
            // textBoxSearchCriteria
            // 
            this.textBoxSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCriteria.Location = new System.Drawing.Point(379, 450);
            this.textBoxSearchCriteria.Name = "textBoxSearchCriteria";
            this.textBoxSearchCriteria.Size = new System.Drawing.Size(135, 26);
            this.textBoxSearchCriteria.TabIndex = 27;
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCriteria.Location = new System.Drawing.Point(401, 415);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(88, 20);
            this.labelCriteria.TabIndex = 28;
            this.labelCriteria.Text = "All Patients";
            // 
            // AppointmentScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 656);
            this.Controls.Add(this.labelCriteria);
            this.Controls.Add(this.textBoxSearchCriteria);
            this.Controls.Add(this.buttonSearchPatients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSearchDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSearchCriteria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonScheduleAppointment);
            this.Controls.Add(this.monthCalendarScheduleAppointment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentScheduleForm";
            this.Text = "AppointmentScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendarScheduleAppointment;
        private System.Windows.Forms.Button buttonScheduleAppointment;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSearchDoctor;
        private System.Windows.Forms.Button buttonSearchPatients;
        private System.Windows.Forms.TextBox textBoxSearchCriteria;
        private System.Windows.Forms.Label labelCriteria;
    }
}