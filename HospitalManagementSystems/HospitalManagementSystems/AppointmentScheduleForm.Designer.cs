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
            this.monthCalendarScheduleAppointment = new System.Windows.Forms.MonthCalendar();
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSearchDoctor = new System.Windows.Forms.ComboBox();
            this.dataGridViewPastVisit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // monthCalendarScheduleAppointment
            // 
            this.monthCalendarScheduleAppointment.Location = new System.Drawing.Point(737, 698);
            this.monthCalendarScheduleAppointment.Name = "monthCalendarScheduleAppointment";
            this.monthCalendarScheduleAppointment.TabIndex = 2;
            // 
            // buttonScheduleAppointment
            // 
            this.buttonScheduleAppointment.BackColor = System.Drawing.Color.LightGreen;
            this.buttonScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleAppointment.Location = new System.Drawing.Point(250, 698);
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
            this.buttonExit.Location = new System.Drawing.Point(489, 698);
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
            this.label4.Location = new System.Drawing.Point(54, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Search Doctor";
            // 
            // comboBoxSearchDoctor
            // 
            this.comboBoxSearchDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchDoctor.FormattingEnabled = true;
            this.comboBoxSearchDoctor.Location = new System.Drawing.Point(58, 698);
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
            // AppointmentScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1079, 936);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPastVisit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSearchDoctor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonScheduleAppointment);
            this.Controls.Add(this.monthCalendarScheduleAppointment);
            this.Controls.Add(this.dataGridViewUpcomingVisit);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentScheduleForm";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingVisit;
        private System.Windows.Forms.MonthCalendar monthCalendarScheduleAppointment;
        private System.Windows.Forms.Button buttonScheduleAppointment;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSearchDoctor;
        private System.Windows.Forms.DataGridView dataGridViewPastVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}