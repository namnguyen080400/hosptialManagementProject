﻿namespace HospitalManagementSystems
{
    partial class PatientHomepageForm
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
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.buttonMedications = new System.Windows.Forms.Button();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonVisit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Homepage";
            // 
            // buttonScheduleAppointment
            // 
            this.buttonScheduleAppointment.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleAppointment.Location = new System.Drawing.Point(131, 224);
            this.buttonScheduleAppointment.Name = "buttonScheduleAppointment";
            this.buttonScheduleAppointment.Size = new System.Drawing.Size(125, 50);
            this.buttonScheduleAppointment.TabIndex = 1;
            this.buttonScheduleAppointment.Text = "Schedule an appointment";
            this.buttonScheduleAppointment.UseVisualStyleBackColor = false;
            this.buttonScheduleAppointment.Click += new System.EventHandler(this.buttonScheduleAppointment_Click);
            // 
            // buttonMedications
            // 
            this.buttonMedications.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedications.Location = new System.Drawing.Point(273, 224);
            this.buttonMedications.Name = "buttonMedications";
            this.buttonMedications.Size = new System.Drawing.Size(110, 50);
            this.buttonMedications.TabIndex = 2;
            this.buttonMedications.Text = "Medications";
            this.buttonMedications.UseVisualStyleBackColor = false;
            // 
            // buttonMessage
            // 
            this.buttonMessage.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessage.Location = new System.Drawing.Point(398, 224);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(98, 50);
            this.buttonMessage.TabIndex = 3;
            this.buttonMessage.Text = "Message";
            this.buttonMessage.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Red;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(661, 224);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(98, 50);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonVisit
            // 
            this.buttonVisit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisit.Location = new System.Drawing.Point(523, 224);
            this.buttonVisit.Name = "buttonVisit";
            this.buttonVisit.Size = new System.Drawing.Size(98, 50);
            this.buttonVisit.TabIndex = 5;
            this.buttonVisit.Text = "Visit";
            this.buttonVisit.UseVisualStyleBackColor = false;
            this.buttonVisit.Click += new System.EventHandler(this.buttonVisit_Click);
            // 
            // PatientHomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(973, 581);
            this.Controls.Add(this.buttonVisit);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.buttonMedications);
            this.Controls.Add(this.buttonScheduleAppointment);
            this.Controls.Add(this.label1);
            this.Name = "PatientHomepageForm";
            this.Text = "PatientHomepageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonScheduleAppointment;
        private System.Windows.Forms.Button buttonMedications;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonVisit;
    }
}