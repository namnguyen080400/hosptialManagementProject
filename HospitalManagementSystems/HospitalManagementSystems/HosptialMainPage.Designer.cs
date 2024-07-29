namespace HospitalManagementSystems
{
    partial class HosptialMainPage
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
            this.buttonPatientManagement = new System.Windows.Forms.Button();
            this.buttonMedicalInventoryManagement = new System.Windows.Forms.Button();
            this.buttonAppointmentScheduling = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hosptial Main Page";
            // 
            // buttonPatientManagement
            // 
            this.buttonPatientManagement.BackColor = System.Drawing.Color.Cyan;
            this.buttonPatientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientManagement.Location = new System.Drawing.Point(203, 157);
            this.buttonPatientManagement.Name = "buttonPatientManagement";
            this.buttonPatientManagement.Size = new System.Drawing.Size(170, 57);
            this.buttonPatientManagement.TabIndex = 1;
            this.buttonPatientManagement.Text = "Patient Management";
            this.buttonPatientManagement.UseVisualStyleBackColor = false;
            // 
            // buttonMedicalInventoryManagement
            // 
            this.buttonMedicalInventoryManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMedicalInventoryManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicalInventoryManagement.Location = new System.Drawing.Point(203, 246);
            this.buttonMedicalInventoryManagement.Name = "buttonMedicalInventoryManagement";
            this.buttonMedicalInventoryManagement.Size = new System.Drawing.Size(170, 57);
            this.buttonMedicalInventoryManagement.TabIndex = 2;
            this.buttonMedicalInventoryManagement.Text = "Medical Inventory Management";
            this.buttonMedicalInventoryManagement.UseVisualStyleBackColor = false;
            // 
            // buttonAppointmentScheduling
            // 
            this.buttonAppointmentScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAppointmentScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentScheduling.Location = new System.Drawing.Point(397, 157);
            this.buttonAppointmentScheduling.Name = "buttonAppointmentScheduling";
            this.buttonAppointmentScheduling.Size = new System.Drawing.Size(170, 57);
            this.buttonAppointmentScheduling.TabIndex = 3;
            this.buttonAppointmentScheduling.Text = "Appointment Scheduling";
            this.buttonAppointmentScheduling.UseVisualStyleBackColor = false;
            this.buttonAppointmentScheduling.Click += new System.EventHandler(this.buttonAppointmentScheduling_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(397, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "Message";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(296, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(170, 57);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // HosptialMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(740, 566);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAppointmentScheduling);
            this.Controls.Add(this.buttonMedicalInventoryManagement);
            this.Controls.Add(this.buttonPatientManagement);
            this.Controls.Add(this.label1);
            this.Name = "HosptialMainPage";
            this.Text = "HosptialMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPatientManagement;
        private System.Windows.Forms.Button buttonMedicalInventoryManagement;
        private System.Windows.Forms.Button buttonAppointmentScheduling;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonExit;
    }
}