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
            this.dataGridViewUpcomingVisit = new System.Windows.Forms.DataGridView();
            this.monthCalendarUpcomingVisitDate = new System.Windows.Forms.MonthCalendar();
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSearchDoctor = new System.Windows.Forms.ComboBox();
            this.dataGridViewPastVisit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVisitType = new System.Windows.Forms.ComboBox();
            this.buttonLoadUpcomingVisit = new System.Windows.Forms.Button();
            this.buttonLoadPastVisit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Appointment";
            // 
            // dataGridViewUpcomingVisit
            // 
            this.dataGridViewUpcomingVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingVisit.Location = new System.Drawing.Point(47, 123);
            this.dataGridViewUpcomingVisit.Name = "dataGridViewUpcomingVisit";
            this.dataGridViewUpcomingVisit.Size = new System.Drawing.Size(908, 216);
            this.dataGridViewUpcomingVisit.TabIndex = 1;
            // 
            // monthCalendarUpcomingVisitDate
            // 
            this.monthCalendarUpcomingVisitDate.Location = new System.Drawing.Point(737, 698);
            this.monthCalendarUpcomingVisitDate.Name = "monthCalendarUpcomingVisitDate";
            this.monthCalendarUpcomingVisitDate.TabIndex = 2;
            // 
            // buttonScheduleAppointment
            // 
            this.buttonScheduleAppointment.BackColor = System.Drawing.Color.LightGreen;
            this.buttonScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleAppointment.Location = new System.Drawing.Point(463, 698);
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
            this.buttonExit.Location = new System.Drawing.Point(341, 864);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(156, 49);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Search Doctor";
            // 
            // comboBoxSearchDoctor
            // 
            this.comboBoxSearchDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchDoctor.FormattingEnabled = true;
            this.comboBoxSearchDoctor.Location = new System.Drawing.Point(271, 698);
            this.comboBoxSearchDoctor.Name = "comboBoxSearchDoctor";
            this.comboBoxSearchDoctor.Size = new System.Drawing.Size(162, 28);
            this.comboBoxSearchDoctor.TabIndex = 24;
            // 
            // dataGridViewPastVisit
            // 
            this.dataGridViewPastVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPastVisit.Location = new System.Drawing.Point(47, 411);
            this.dataGridViewPastVisit.Name = "dataGridViewPastVisit";
            this.dataGridViewPastVisit.Size = new System.Drawing.Size(908, 216);
            this.dataGridViewPastVisit.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Upcoming Visit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Past Visit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(775, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Appointment Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 664);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Visit Type";
            // 
            // comboBoxVisitType
            // 
            this.comboBoxVisitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVisitType.FormattingEnabled = true;
            this.comboBoxVisitType.Location = new System.Drawing.Point(69, 698);
            this.comboBoxVisitType.Name = "comboBoxVisitType";
            this.comboBoxVisitType.Size = new System.Drawing.Size(162, 28);
            this.comboBoxVisitType.TabIndex = 30;
            // 
            // buttonLoadUpcomingVisit
            // 
            this.buttonLoadUpcomingVisit.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonLoadUpcomingVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadUpcomingVisit.Location = new System.Drawing.Point(1013, 219);
            this.buttonLoadUpcomingVisit.Name = "buttonLoadUpcomingVisit";
            this.buttonLoadUpcomingVisit.Size = new System.Drawing.Size(156, 49);
            this.buttonLoadUpcomingVisit.TabIndex = 32;
            this.buttonLoadUpcomingVisit.Text = "Load Upcoming Visit";
            this.buttonLoadUpcomingVisit.UseVisualStyleBackColor = false;
            this.buttonLoadUpcomingVisit.Click += new System.EventHandler(this.buttonLoadUpcomingVisit_Click);
            // 
            // buttonLoadPastVisit
            // 
            this.buttonLoadPastVisit.BackColor = System.Drawing.Color.Coral;
            this.buttonLoadPastVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadPastVisit.Location = new System.Drawing.Point(1013, 499);
            this.buttonLoadPastVisit.Name = "buttonLoadPastVisit";
            this.buttonLoadPastVisit.Size = new System.Drawing.Size(156, 49);
            this.buttonLoadPastVisit.TabIndex = 33;
            this.buttonLoadPastVisit.Text = "Load Past Visit";
            this.buttonLoadPastVisit.UseVisualStyleBackColor = false;
            this.buttonLoadPastVisit.Click += new System.EventHandler(this.buttonLoadPastVisit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(990, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Click to load upcoming visit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(990, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Click to load past visit";
            // 
            // AppointmentScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 936);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonLoadPastVisit);
            this.Controls.Add(this.buttonLoadUpcomingVisit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxVisitType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPastVisit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSearchDoctor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonScheduleAppointment);
            this.Controls.Add(this.monthCalendarUpcomingVisitDate);
            this.Controls.Add(this.dataGridViewUpcomingVisit);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentScheduleForm";
            this.Text = "Schedule Appointment Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingVisit;
        private System.Windows.Forms.MonthCalendar monthCalendarUpcomingVisitDate;
        private System.Windows.Forms.Button buttonScheduleAppointment;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSearchDoctor;
        private System.Windows.Forms.DataGridView dataGridViewPastVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVisitType;
        private System.Windows.Forms.Button buttonLoadUpcomingVisit;
        private System.Windows.Forms.Button buttonLoadPastVisit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}